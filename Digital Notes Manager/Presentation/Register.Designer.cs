namespace Digital_Notes_Manager.Presentation
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
            Passwordtxt = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            UserNametxt = new TextBox();
            textBox3 = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            Registerpb = new PictureBox();
            label3 = new Label();
            SignUpbtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            textBox4 = new TextBox();
            panel4 = new Panel();
            ConfirmPasswordtxt = new TextBox();
            pictureBox5 = new PictureBox();
            LogInlkl = new LinkLabel();
            usernameErrorLbl = new Label();
            passwordErrorLbl = new Label();
            confirmPassErrorLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Registerpb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // Passwordtxt
            // 
            Passwordtxt.BorderStyle = BorderStyle.None;
            Passwordtxt.Location = new Point(3, 5);
            Passwordtxt.MaximumSize = new Size(300, 50);
            Passwordtxt.Multiline = true;
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.PasswordChar = '*';
            Passwordtxt.PlaceholderText = "Enter Your Password";
            Passwordtxt.Size = new Size(293, 30);
            Passwordtxt.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 50, 56);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 495);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(38, 50, 56);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 537);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(527, 83);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 17;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(527, 186);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 16;
            label1.Text = "Password";
            // 
            // UserNametxt
            // 
            UserNametxt.BorderStyle = BorderStyle.None;
            UserNametxt.Location = new Point(3, 5);
            UserNametxt.Multiline = true;
            UserNametxt.Name = "UserNametxt";
            UserNametxt.PlaceholderText = "Enter Your User Name";
            UserNametxt.Size = new Size(293, 30);
            UserNametxt.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(583, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(0, 27);
            textBox3.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 50, 56);
            panel3.Controls.Add(Passwordtxt);
            panel3.Location = new Point(490, 225);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 40);
            panel3.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 50, 56);
            panel2.Controls.Add(UserNametxt);
            panel2.Location = new Point(490, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 40);
            panel2.TabIndex = 25;
            // 
            // Registerpb
            // 
            Registerpb.Cursor = Cursors.Hand;
            Registerpb.Image = (Image)resources.GetObject("Registerpb.Image");
            Registerpb.Location = new Point(748, 9);
            Registerpb.Name = "Registerpb";
            Registerpb.Size = new Size(35, 35);
            Registerpb.TabIndex = 24;
            Registerpb.TabStop = false;
            Registerpb.Click += Registerpb_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(38, 50, 56);
            label3.Location = new Point(526, -6);
            label3.Name = "label3";
            label3.Size = new Size(167, 66);
            label3.TabIndex = 23;
            label3.Text = "Sign Up";
            // 
            // SignUpbtn
            // 
            SignUpbtn.BackColor = Color.FromArgb(38, 50, 56);
            SignUpbtn.FlatAppearance.BorderColor = Color.FromArgb(186, 104, 200);
            SignUpbtn.FlatStyle = FlatStyle.Flat;
            SignUpbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpbtn.ForeColor = Color.White;
            SignUpbtn.Location = new Point(493, 405);
            SignUpbtn.Name = "SignUpbtn";
            SignUpbtn.Size = new Size(298, 39);
            SignUpbtn.TabIndex = 21;
            SignUpbtn.Text = "Sign Up";
            SignUpbtn.UseVisualStyleBackColor = false;
            SignUpbtn.Click += SignUpbtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(491, 184);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(491, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(527, 295);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 27;
            label4.Text = "Confirm Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(585, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(0, 27);
            textBox4.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(38, 50, 56);
            panel4.Controls.Add(ConfirmPasswordtxt);
            panel4.Location = new Point(490, 334);
            panel4.Name = "panel4";
            panel4.Size = new Size(299, 40);
            panel4.TabIndex = 30;
            // 
            // ConfirmPasswordtxt
            // 
            ConfirmPasswordtxt.BorderStyle = BorderStyle.None;
            ConfirmPasswordtxt.Location = new Point(3, 5);
            ConfirmPasswordtxt.MaximumSize = new Size(300, 50);
            ConfirmPasswordtxt.Multiline = true;
            ConfirmPasswordtxt.Name = "ConfirmPasswordtxt";
            ConfirmPasswordtxt.PasswordChar = '*';
            ConfirmPasswordtxt.PlaceholderText = "Confirm Password";
            ConfirmPasswordtxt.Size = new Size(293, 30);
            ConfirmPasswordtxt.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(491, 290);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // LogInlkl
            // 
            LogInlkl.ActiveLinkColor = Color.Blue;
            LogInlkl.AutoSize = true;
            LogInlkl.DisabledLinkColor = Color.Black;
            LogInlkl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInlkl.LinkColor = Color.Black;
            LogInlkl.Location = new Point(547, 456);
            LogInlkl.Name = "LogInlkl";
            LogInlkl.Size = new Size(194, 20);
            LogInlkl.TabIndex = 32;
            LogInlkl.TabStop = true;
            LogInlkl.Text = "Already Have An Account?";
            LogInlkl.LinkClicked += LogInlkl_LinkClicked;
            // 
            // usernameErrorLbl
            // 
            usernameErrorLbl.AutoSize = true;
            usernameErrorLbl.ForeColor = Color.Red;
            usernameErrorLbl.Location = new Point(490, 157);
            usernameErrorLbl.Name = "usernameErrorLbl";
            usernameErrorLbl.Size = new Size(193, 20);
            usernameErrorLbl.TabIndex = 33;
            usernameErrorLbl.Text = "Please enter valid username";
            usernameErrorLbl.Visible = false;
            // 
            // passwordErrorLbl
            // 
            passwordErrorLbl.AutoSize = true;
            passwordErrorLbl.ForeColor = Color.Red;
            passwordErrorLbl.Location = new Point(493, 267);
            passwordErrorLbl.Name = "passwordErrorLbl";
            passwordErrorLbl.Size = new Size(192, 20);
            passwordErrorLbl.TabIndex = 34;
            passwordErrorLbl.Text = "Please enter valid password";
            passwordErrorLbl.Visible = false;
            // 
            // confirmPassErrorLbl
            // 
            confirmPassErrorLbl.AutoSize = true;
            confirmPassErrorLbl.ForeColor = Color.Red;
            confirmPassErrorLbl.Location = new Point(493, 375);
            confirmPassErrorLbl.Name = "confirmPassErrorLbl";
            confirmPassErrorLbl.Size = new Size(155, 20);
            confirmPassErrorLbl.TabIndex = 35;
            confirmPassErrorLbl.Text = "Password is not match";
            confirmPassErrorLbl.Visible = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(831, 495);
            Controls.Add(confirmPassErrorLbl);
            Controls.Add(passwordErrorLbl);
            Controls.Add(usernameErrorLbl);
            Controls.Add(LogInlkl);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(pictureBox5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(Registerpb);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(SignUpbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Registerpb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Passwordtxt;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox UserNametxt;
        private TextBox textBox3;
        private Panel panel3;
        private Panel panel2;
        private PictureBox Registerpb;
        private Label label3;
        private Button SignUpbtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox textBox4;
        private Panel panel4;
        private TextBox ConfirmPasswordtxt;
        private PictureBox pictureBox5;
        private LinkLabel LogInlkl;
        private Label usernameErrorLbl;
        private Label passwordErrorLbl;
        private Label confirmPassErrorLbl;
    }
}