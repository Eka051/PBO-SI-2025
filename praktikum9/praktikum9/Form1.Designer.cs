namespace praktikum9
{
    partial class Form1
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
            label1 = new Label();
            TBUsername = new TextBox();
            label2 = new Label();
            TBPassword = new TextBox();
            label3 = new Label();
            BtnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(352, 137);
            label1.Name = "label1";
            label1.Size = new Size(238, 33);
            label1.TabIndex = 0;
            label1.Text = "Halaman Register";
            // 
            // TBUsername
            // 
            TBUsername.Location = new Point(352, 217);
            TBUsername.Margin = new Padding(3, 4, 3, 4);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(215, 27);
            TBUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 193);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(352, 285);
            TBPassword.Margin = new Padding(3, 4, 3, 4);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(215, 27);
            TBPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 261);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // BtnRegister
            // 
            BtnRegister.BackColor = Color.LightSkyBlue;
            BtnRegister.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegister.Location = new Point(367, 340);
            BtnRegister.Margin = new Padding(3, 4, 3, 4);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(176, 61);
            BtnRegister.TabIndex = 5;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(BtnRegister);
            Controls.Add(label3);
            Controls.Add(TBPassword);
            Controls.Add(label2);
            Controls.Add(TBUsername);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBUsername;
        private Label label2;
        private TextBox TBPassword;
        private Label label3;
        private Button BtnRegister;
    }
}
