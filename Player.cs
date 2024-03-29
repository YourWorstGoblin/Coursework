﻿using Coursework.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    [Serializable]
    public class player
    {
        public string username { get; set; }
        public string password { get; set; }
        public int currentScore { get; set; }
        public int topWildScore { get; set; }
        public int topBaseScore { get; set; }
        public char defaultPFP { get; set; }
        public Image ProfilePicture { get; set; }
        public int runCount { get; set; }

        public player(string name, string pass)
        {
            this.username = name;
            this.password = pass;
            this.currentScore = 0;
            this.runCount = 0;
            if (!File.Exists(@"scores.bin")) { File.WriteAllText("scores.bin", ""); }
            using (StreamReader reader = new StreamReader("scores.bin"))
            {
                string line;
                bool found = false;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace("\u000e", "");
                    string[] parts = line.Split(',');
                    if (parts[0] == this.username)
                    {
                        topWildScore = Convert.ToInt32(parts[1]);
                        topBaseScore = Convert.ToInt32(parts[2]);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    topWildScore = 0;
                    topBaseScore = 0;
                }
            }





        }
        public void AccumulativeReset()
        {
            Ready.timeKeeperInstance = null;
            this.currentScore = 0;
            this.runCount++;
            var lines = File.ReadAllLines("userDatabase.csv").ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var columns = lines[i].Split(',');

                if (columns[0] == this.username) // assuming username is in the first column
                {
                    int lastColumnIndex = columns.Length - 1;
                    columns[lastColumnIndex] = (this.runCount).ToString();

                    lines[i] = string.Join(",", columns);
                    break;
                }
            }

            File.WriteAllLines("userDatabase.csv", lines);
        }
        public void Accumulate()
        {
            this.currentScore++;
            new System.Media.SoundPlayer(Resources.Correct_Ding).Play();
        }
        public void CreateDatabaseForPlayer()
        {
            File.WriteAllText("userDatabase.csv", (this.username + "," + this.password + "," + this.defaultPFP + "," + "0" + Environment.NewLine));
        }
        public void AddToDatabase()
        {
            File.AppendAllText("userDatabase.csv",(this.username + "," + this.password + ","  + this.defaultPFP + ","+ "0" + Environment.NewLine));
        }



        public void UpdateScoresBinFile(int newScore, string mode)
        {
            bool updated = false;
            bool found = false;
            if(mode == "wildcard")
            {
                if (newScore > topWildScore)
                {
                    topWildScore = newScore;
                    updated = true;
                }
            }
            else if (mode == "base")
            {
                if (newScore > topBaseScore)
                {
                    topBaseScore = newScore;
                    updated = true;
                }
            }
            if (updated)
            {
                string tempFile = Path.GetTempFileName();
                using (var sr = new StreamReader("scores.bin"))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts[0] == username)
                        {
                            parts[1] = topWildScore.ToString();
                            parts[2] = topBaseScore.ToString();
                            line = string.Join(",", parts);
                            found = true;
                        }
                        sw.WriteLine(line);
                    }
                    if (!found)
                    {
                        sw.WriteLine(username + "," + topWildScore + "," + topBaseScore);
                    }
                }
                File.Delete("scores.bin");
                File.Move(tempFile, "scores.bin");
            }
            


        }
    }
}
