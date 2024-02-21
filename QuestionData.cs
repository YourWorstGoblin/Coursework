﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class QuestionData
    {
        public int response_code { get; set; }
        public List<questionInfo> results { get; set; }
        public int questionNo { get; set; }
    }
    public class questionInfo
    {
        public string type { get; set; }
        public string difficulty { get; set; }
        public string category { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public List<string> incorrect_answers { get; set; }
    }

}
