namespace praktikum_CRUD
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnShowPassword = new Button();
            label4 = new Label();
            registerLink = new LinkLabel();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.login_bg;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnShowPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(registerLink);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(553, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 378);
            panel1.TabIndex = 0;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackgroundImage = Properties.Resources.eyeOn;
            btnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowPassword.Location = new Point(274, 194);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(35, 32);
            btnShowPassword.TabIndex = 3;
            btnShowPassword.Text = " ";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 322);
            label4.Name = "label4";
            label4.Size = new Size(155, 19);
            label4.TabIndex = 7;
            label4.Text = "Belum punya akun?";
            // 
            // registerLink
            // 
            registerLink.AutoSize = true;
            registerLink.BackColor = Color.Transparent;
            registerLink.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLink.LinkBehavior = LinkBehavior.NeverUnderline;
            registerLink.LinkColor = Color.Yellow;
            registerLink.Location = new Point(212, 322);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(80, 19);
            registerLink.TabIndex = 5;
            registerLink.TabStop = true;
            registerLink.Text = "Register";
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(57, 203);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(211, 23);
            tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(57, 121);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(247, 23);
            tbUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gold;
            btnLogin.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(42, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(276, 53);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 162);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 75);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(145, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 29);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.login_vector;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(84, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 318);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 661);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private PictureBox pictureBox1;
        private LinkLabel registerLink;
        private Label label4;
        private Button btnShowPassword;
    }
}
