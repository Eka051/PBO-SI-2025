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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 72);
            label1.Name = "label1";
            label1.Size = new Size(203, 33);
            label1.TabIndex = 0;
            label1.Text = "Halaman Login";
            label1.Click += label1_Click;
            // 
            // tbusernamelog
            // 
            tbusernamelog.Location = new Point(262, 168);
            tbusernamelog.Name = "tbusernamelog";
            tbusernamelog.Size = new Size(253, 27);
            tbusernamelog.TabIndex = 1;
            // 
            // tbpasswordlog
            // 
            tbpasswordlog.Location = new Point(262, 233);
            tbpasswordlog.Name = "tbpasswordlog";
            tbpasswordlog.Size = new Size(253, 27);
            tbpasswordlog.TabIndex = 2;
            tbpasswordlog.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 145);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 210);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(262, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(253, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Hallogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbpasswordlog);
            Controls.Add(tbusernamelog);
            Controls.Add(label1);
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
    }
}