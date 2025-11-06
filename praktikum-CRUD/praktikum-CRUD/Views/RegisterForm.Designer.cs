namespace praktikum_CRUD.View
{
    partial class RegisterForm
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnShowPassword = new Button();
            label4 = new Label();
            loginLink = new LinkLabel();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.register_vector;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(91, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 318);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.register_bg;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnShowPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(loginLink);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(560, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 378);
            panel1.TabIndex = 2;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackgroundImage = Properties.Resources.eyeOn;
            btnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
            btnShowPassword.Location = new Point(274, 195);
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
            label4.ForeColor = Color.Black;
            label4.Location = new Point(59, 322);
            label4.Name = "label4";
            label4.Size = new Size(161, 19);
            label4.TabIndex = 7;
            label4.Text = " Sudah punya akun?";
            // 
            // loginLink
            // 
            loginLink.AutoSize = true;
            loginLink.BackColor = Color.Transparent;
            loginLink.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLink.LinkBehavior = LinkBehavior.NeverUnderline;
            loginLink.LinkColor = Color.Green;
            loginLink.Location = new Point(227, 322);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(57, 19);
            loginLink.TabIndex = 5;
            loginLink.TabStop = true;
            loginLink.Text = "Login";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(57, 203);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(206, 23);
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
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(42, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(276, 53);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Sign Up";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
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
            label2.ForeColor = Color.Black;
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
            label1.ForeColor = Color.Black;
            label1.Location = new Point(130, 34);
            label1.Name = "label1";
            label1.Size = new Size(111, 29);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 661);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
        private LinkLabel loginLink;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnShowPassword;
    }
}