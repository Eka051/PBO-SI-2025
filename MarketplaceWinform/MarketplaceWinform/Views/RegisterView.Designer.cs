namespace MarketplaceWinform.Views
{
    partial class RegisterView
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRegister = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            tbFullname = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.register_page;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(tbFullname);
            panel1.Location = new Point(436, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 480);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 298);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 217);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 133);
            label2.Name = "label2";
            label2.Size = new Size(135, 19);
            label2.TabIndex = 4;
            label2.Text = "Nama Lengkap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(118, 79);
            label1.Name = "label1";
            label1.Size = new Size(125, 33);
            label1.TabIndex = 1;
            label1.Text = "Register";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LimeGreen;
            btnRegister.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(29, 392);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(295, 49);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Daftar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(44, 335);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(280, 20);
            tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(44, 253);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(280, 20);
            tbUsername.TabIndex = 1;
            // 
            // tbFullname
            // 
            tbFullname.BorderStyle = BorderStyle.None;
            tbFullname.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFullname.Location = new Point(44, 170);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(268, 20);
            tbFullname.TabIndex = 0;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Name = "RegisterView";
            Text = "RegisterView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegister;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private TextBox tbFullname;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}