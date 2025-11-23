namespace MarketplaceWinform.Views
{
    partial class LoginView
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
            panel1 = new Panel();
            tbUsername = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbPassword = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.login_page;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(461, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 417);
            panel1.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(37, 198);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(268, 20);
            tbUsername.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(37, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 20);
            textBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 237);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 158);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 88);
            label1.Name = "label1";
            label1.Size = new Size(104, 39);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(37, 274);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(268, 20);
            tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGreen;
            btnLogin.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(18, 329);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(299, 51);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Masuk";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Name = "LoginView";
            Text = "LoginView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbUsername;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbPassword;
        private Button btnLogin;
    }
}