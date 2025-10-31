namespace praktikum9
{
    partial class Hallogin
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
            label1 = new Label();
            tbusernamelog = new TextBox();
            tbpasswordlog = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(369, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 33);
            label1.TabIndex = 0;
            label1.Text = "Halaman Login";
            label1.Click += label1_Click;
            // 
            // tbusernamelog
            // 
            tbusernamelog.Location = new Point(328, 210);
            tbusernamelog.Margin = new Padding(4, 4, 4, 4);
            tbusernamelog.Name = "tbusernamelog";
            tbusernamelog.Size = new Size(315, 31);
            tbusernamelog.TabIndex = 1;
            // 
            // tbpasswordlog
            // 
            tbpasswordlog.Location = new Point(328, 291);
            tbpasswordlog.Margin = new Padding(4, 4, 4, 4);
            tbpasswordlog.Name = "tbpasswordlog";
            tbpasswordlog.Size = new Size(315, 31);
            tbpasswordlog.TabIndex = 2;
            tbpasswordlog.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 181);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 262);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(328, 361);
            btnLogin.Margin = new Padding(4, 4, 4, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(223, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(558, 363);
            button1.Name = "button1";
            button1.Size = new Size(85, 34);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
   
            // 
            // Hallogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbpasswordlog);
            Controls.Add(tbusernamelog);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Hallogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hallogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbusernamelog;
        private TextBox tbpasswordlog;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button button1;
    }
}