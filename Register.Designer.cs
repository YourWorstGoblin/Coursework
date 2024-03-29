﻿namespace Coursework
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            Title = new Label();
            pictureBox2 = new PictureBox();
            coolButton1 = new CoolButton();
            UsernameF = new TextBox();
            PasswordF = new TextBox();
            CPasswordF = new TextBox();
            pDisclaimer = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            Hide = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hide).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Itim", 44F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(269, 49);
            Title.Name = "Title";
            Title.Size = new Size(238, 71);
            Title.TabIndex = 3;
            Title.Text = "Register";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image__1_;
            pictureBox2.Location = new Point(89, 176);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(599, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
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
            coolButton1.Location = new Point(486, 442);
            coolButton1.Margin = new Padding(3, 2, 3, 2);
            coolButton1.Name = "coolButton1";
            coolButton1.Size = new Size(202, 68);
            coolButton1.TabIndex = 4;
            coolButton1.Text = "Register";
            coolButton1.UseVisualStyleBackColor = false;
            coolButton1.Click += coolButton1_Click;
            // 
            // UsernameF
            // 
            UsernameF.BorderStyle = BorderStyle.None;
            UsernameF.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameF.ForeColor = Color.FromArgb(179, 63, 38);
            UsernameF.Location = new Point(101, 201);
            UsernameF.Margin = new Padding(3, 2, 3, 2);
            UsernameF.Name = "UsernameF";
            UsernameF.PlaceholderText = "Username";
            UsernameF.Size = new Size(571, 32);
            UsernameF.TabIndex = 1;
            // 
            // PasswordF
            // 
            PasswordF.BorderStyle = BorderStyle.None;
            PasswordF.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordF.ForeColor = Color.FromArgb(179, 63, 38);
            PasswordF.Location = new Point(101, 284);
            PasswordF.Margin = new Padding(3, 2, 3, 2);
            PasswordF.Name = "PasswordF";
            PasswordF.PlaceholderText = "Password";
            PasswordF.Size = new Size(571, 32);
            PasswordF.TabIndex = 2;
            PasswordF.UseSystemPasswordChar = true;
            // 
            // CPasswordF
            // 
            CPasswordF.BorderStyle = BorderStyle.None;
            CPasswordF.Font = new Font("Itim", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CPasswordF.ForeColor = Color.FromArgb(179, 63, 38);
            CPasswordF.Location = new Point(101, 367);
            CPasswordF.Margin = new Padding(3, 2, 3, 2);
            CPasswordF.Name = "CPasswordF";
            CPasswordF.PlaceholderText = "Confirm Password";
            CPasswordF.Size = new Size(571, 32);
            CPasswordF.TabIndex = 3;
            CPasswordF.UseSystemPasswordChar = true;
            // 
            // pDisclaimer
            // 
            pDisclaimer.AutoSize = true;
            pDisclaimer.BackColor = Color.Transparent;
            pDisclaimer.Font = new Font("Itim", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pDisclaimer.ForeColor = Color.FromArgb(255, 182, 166);
            pDisclaimer.Location = new Point(89, 427);
            pDisclaimer.Name = "pDisclaimer";
            pDisclaimer.Size = new Size(205, 68);
            pDisclaimer.TabIndex = 11;
            pDisclaimer.Text = "Passwords must be:\nAt least 8 characters long\nContain at least one number\nNot be the same as the username";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.image__1_;
            pictureBox3.Location = new Point(89, 259);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(599, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.image__1_;
            pictureBox4.Location = new Point(89, 342);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(599, 83);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // Hide
            // 
            Hide.Cursor = Cursors.Hand;
            Hide.Image = Properties.Resources.Crossed_Eye;
            Hide.Location = new Point(694, 358);
            Hide.Name = "Hide";
            Hide.Size = new Size(50, 50);
            Hide.SizeMode = PictureBoxSizeMode.Zoom;
            Hide.TabIndex = 14;
            Hide.TabStop = false;
            Hide.MouseCaptureChanged += Hide_MouseCaptureChanged;
            Hide.MouseDown += Hide_Hold;
            // 
            // Register
            // 
            AcceptButton = coolButton1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 63, 38);
            ClientSize = new Size(784, 561);
            Controls.Add(Hide);
            Controls.Add(pDisclaimer);
            Controls.Add(CPasswordF);
            Controls.Add(PasswordF);
            Controls.Add(UsernameF);
            Controls.Add(coolButton1);
            Controls.Add(pictureBox2);
            Controls.Add(Title);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Title;
        private PictureBox pictureBox2;
        private CoolButton coolButton1;
        private TextBox UsernameF;
        private TextBox PasswordF;
        private TextBox CPasswordF;
        private Label pDisclaimer;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox Hide;
    }
}