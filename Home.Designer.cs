﻿namespace Coursework
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            logInButton = new CoolButton();
            registerButton = new CoolButton();
            coolButton1 = new CoolButton();
            Start = new CoolButton();
            logOut = new PictureBox();
            ProfilePicture = new PictureBox();
            usernameSpot = new Label();
            ((System.ComponentModel.ISupportInitialize)logOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 50F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(217, 60);
            Title.Name = "Title";
            Title.Size = new Size(352, 81);
            Title.TabIndex = 12;
            Title.Text = "Trivia Deck";
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.White;
            logInButton.Cursor = Cursors.Hand;
            logInButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            logInButton.FlatAppearance.BorderSize = 5;
            logInButton.FlatStyle = FlatStyle.Flat;
            logInButton.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.ForeColor = Color.FromArgb(179, 63, 38);
            logInButton.Location = new Point(440, 355);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(254, 73);
            logInButton.TabIndex = 15;
            logInButton.Text = "Leaderboard";
            logInButton.UseVisualStyleBackColor = false;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.White;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            registerButton.FlatAppearance.BorderSize = 5;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.ForeColor = Color.FromArgb(179, 63, 38);
            registerButton.Location = new Point(90, 355);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(254, 73);
            registerButton.TabIndex = 14;
            registerButton.Text = "Profiles";
            registerButton.UseVisualStyleBackColor = false;
            // 
            // coolButton1
            // 
            coolButton1.BackColor = Color.White;
            coolButton1.Cursor = Cursors.Hand;
            coolButton1.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            coolButton1.FlatAppearance.BorderSize = 5;
            coolButton1.FlatStyle = FlatStyle.Flat;
            coolButton1.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            coolButton1.ForeColor = Color.FromArgb(179, 63, 38);
            coolButton1.Location = new Point(265, 449);
            coolButton1.Name = "coolButton1";
            coolButton1.Size = new Size(254, 73);
            coolButton1.TabIndex = 16;
            coolButton1.Text = "Runner";
            coolButton1.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            Start.BackColor = Color.White;
            Start.Cursor = Cursors.Hand;
            Start.FlatAppearance.BorderColor = Color.FromArgb(255, 182, 166);
            Start.FlatAppearance.BorderSize = 5;
            Start.FlatStyle = FlatStyle.Flat;
            Start.Font = new Font("Itim", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Start.ForeColor = Color.FromArgb(179, 63, 38);
            Start.Location = new Point(90, 215);
            Start.Name = "Start";
            Start.Size = new Size(604, 111);
            Start.TabIndex = 17;
            Start.Text = "Start Quiz!";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // logOut
            // 
            logOut.Image = Properties.Resources.Exit;
            logOut.Location = new Point(12, 48);
            logOut.Name = "logOut";
            logOut.Size = new Size(84, 79);
            logOut.SizeMode = PictureBoxSizeMode.Zoom;
            logOut.TabIndex = 18;
            logOut.TabStop = false;
            logOut.Click += logOut_Click;
            // 
            // ProfilePicture
            // 
            ProfilePicture.Image = Properties.Resources.Hippo;
            ProfilePicture.Location = new Point(686, 48);
            ProfilePicture.Name = "ProfilePicture";
            ProfilePicture.Size = new Size(86, 79);
            ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            ProfilePicture.TabIndex = 19;
            ProfilePicture.TabStop = false;
            // 
            // usernameSpot
            // 
            usernameSpot.AutoEllipsis = true;
            usernameSpot.BackColor = Color.Transparent;
            usernameSpot.Font = new Font("Itim", 10F, FontStyle.Regular, GraphicsUnit.Point);
            usernameSpot.ForeColor = Color.White;
            usernameSpot.Location = new Point(542, 130);
            usernameSpot.Name = "usernameSpot";
            usernameSpot.Size = new Size(230, 17);
            usernameSpot.TabIndex = 20;
            usernameSpot.Text = "NamePlaceholder";
            usernameSpot.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(usernameSpot);
            Controls.Add(ProfilePicture);
            Controls.Add(logOut);
            Controls.Add(Start);
            Controls.Add(coolButton1);
            Controls.Add(logInButton);
            Controls.Add(registerButton);
            Controls.Add(Title);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)logOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private CoolButton logInButton;
        private CoolButton registerButton;
        private CoolButton coolButton1;
        private CoolButton Start;
        private PictureBox logOut;
        private PictureBox ProfilePicture;
        private Label usernameSpot;
    }
}