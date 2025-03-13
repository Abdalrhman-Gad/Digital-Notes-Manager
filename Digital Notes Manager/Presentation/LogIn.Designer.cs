namespace Digital_Notes_Manager.Presentation
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Passwordtxt = new TextBox();
            UserNametxt = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            LogInbtn = new Button();
            SignUpbtn = new Button();
            label3 = new Label();
            LogInpb = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox3 = new TextBox();
            usernameErrorLbl = new Label();
            passwordErrorLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogInpb).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 50, 56);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 489);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(38, 50, 56);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 533);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(515, 277);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 1;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(515, 159);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // Passwordtxt
            // 
            Passwordtxt.BorderStyle = BorderStyle.None;
            Passwordtxt.Location = new Point(482, 329);
            Passwordtxt.MaximumSize = new Size(300, 50);
            Passwordtxt.Multiline = true;
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.PasswordChar = '*';
            Passwordtxt.PlaceholderText = "Enter Your Password";
            Passwordtxt.Size = new Size(293, 30);
            Passwordtxt.TabIndex = 4;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(479, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(479, 275);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // LogInbtn
            // 
            LogInbtn.BackColor = Color.FromArgb(38, 50, 56);
            LogInbtn.FlatAppearance.BorderColor = Color.FromArgb(186, 104, 200);
            LogInbtn.FlatStyle = FlatStyle.Flat;
            LogInbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInbtn.ForeColor = Color.White;
            LogInbtn.Location = new Point(479, 404);
            LogInbtn.Name = "LogInbtn";
            LogInbtn.Size = new Size(114, 53);
            LogInbtn.TabIndex = 7;
            LogInbtn.Text = "Log In";
            LogInbtn.UseVisualStyleBackColor = false;
            LogInbtn.Click += LogInbtn_Click;
            // 
            // SignUpbtn
            // 
            SignUpbtn.FlatStyle = FlatStyle.Flat;
            SignUpbtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpbtn.ForeColor = Color.FromArgb(38, 50, 56);
            SignUpbtn.Location = new Point(678, 404);
            SignUpbtn.Name = "SignUpbtn";
            SignUpbtn.Size = new Size(94, 53);
            SignUpbtn.TabIndex = 8;
            SignUpbtn.Text = "Sign Up";
            SignUpbtn.UseVisualStyleBackColor = true;
            SignUpbtn.Click += SignUpbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(38, 50, 56);
            label3.Location = new Point(519, 40);
            label3.Name = "label3";
            label3.Size = new Size(212, 66);
            label3.TabIndex = 9;
            label3.Text = "Welcome !";
            // 
            // LogInpb
            // 
            LogInpb.Cursor = Cursors.Hand;
            LogInpb.Image = (Image)resources.GetObject("LogInpb.Image");
            LogInpb.Location = new Point(737, 12);
            LogInpb.Name = "LogInpb";
            LogInpb.Size = new Size(35, 35);
            LogInpb.TabIndex = 10;
            LogInpb.TabStop = false;
            LogInpb.Click += LogInpb_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 50, 56);
            panel2.Controls.Add(UserNametxt);
            panel2.Location = new Point(479, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 40);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 50, 56);
            panel3.Location = new Point(479, 324);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 40);
            panel3.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(572, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(0, 27);
            textBox3.TabIndex = 4;
            // 
            // usernameErrorLbl
            // 
            usernameErrorLbl.AutoSize = true;
            usernameErrorLbl.ForeColor = Color.Red;
            usernameErrorLbl.Location = new Point(479, 235);
            usernameErrorLbl.Name = "usernameErrorLbl";
            usernameErrorLbl.Size = new Size(193, 20);
            usernameErrorLbl.TabIndex = 15;
            usernameErrorLbl.Text = "Please enter valid username";
            usernameErrorLbl.Visible = false;
            // 
            // passwordErrorLbl
            // 
            passwordErrorLbl.AutoSize = true;
            passwordErrorLbl.ForeColor = Color.Red;
            passwordErrorLbl.Location = new Point(479, 368);
            passwordErrorLbl.Name = "passwordErrorLbl";
            passwordErrorLbl.Size = new Size(192, 20);
            passwordErrorLbl.TabIndex = 16;
            passwordErrorLbl.Text = "Please enter valid password";
            passwordErrorLbl.Visible = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 489);
            Controls.Add(Passwordtxt);
            Controls.Add(passwordErrorLbl);
            Controls.Add(usernameErrorLbl);
            Controls.Add(textBox3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(LogInpb);
            Controls.Add(label3);
            Controls.Add(SignUpbtn);
            Controls.Add(LogInbtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogInpb).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox Passwordtxt;
        private TextBox UserNametxt;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button LogInbtn;
        private Button SignUpbtn;
        private Label label3;
        private PictureBox LogInpb;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox3;
        private Label usernameErrorLbl;
        private Label passwordErrorLbl;
    }
}
