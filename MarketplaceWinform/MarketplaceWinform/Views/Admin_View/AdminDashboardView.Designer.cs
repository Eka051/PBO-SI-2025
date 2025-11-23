namespace MarketplaceWinform.Views.Admin
{
    partial class AdminDashboardView
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
            panel1 = new Panel();
            btnDashboard = new Button();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel8 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label_totalProduk = new Label();
            label3 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            label5 = new Label();
            btnTambahProduk = new Button();
            btnRefreshData = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(222, 29);
            label1.TabIndex = 0;
            label1.Text = "Dashboard Admin";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnRefreshData);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 681);
            panel1.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkGreen;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.dashboard_icon;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 99);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(181, 45);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "Beranda";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(213, 84);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 29);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 0;
            label2.Text = "OrchidMart.id";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LimeGreen;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(213, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1051, 84);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Location = new Point(260, 212);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(975, 457);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.card_product;
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Controls.Add(button3);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(334, 134);
            panel8.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button3.Location = new Point(244, 91);
            button3.Name = "button3";
            button3.Size = new Size(72, 23);
            button3.TabIndex = 7;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(118, 91);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 6;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Inter Medium", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlDark;
            label12.Location = new Point(118, 65);
            label12.Name = "label12";
            label12.Size = new Size(108, 19);
            label12.TabIndex = 5;
            label12.Text = "Stok Produk";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(118, 43);
            label11.Name = "label11";
            label11.Size = new Size(131, 19);
            label11.TabIndex = 4;
            label11.Text = "Rp. 3.450.000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(118, 18);
            label10.Name = "label10";
            label10.Size = new Size(123, 19);
            label10.TabIndex = 2;
            label10.Text = "Nama Produk";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources._409869064_fee39e18_0bd6_4a09_9878_c4f7e859769e;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label_totalProduk);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(260, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 71);
            panel4.TabIndex = 4;
            // 
            // label_totalProduk
            // 
            label_totalProduk.AutoSize = true;
            label_totalProduk.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_totalProduk.ForeColor = Color.Green;
            label_totalProduk.Location = new Point(15, 38);
            label_totalProduk.Name = "label_totalProduk";
            label_totalProduk.Size = new Size(40, 19);
            label_totalProduk.TabIndex = 1;
            label_totalProduk.Text = "100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 13);
            label3.Name = "label3";
            label3.Size = new Size(118, 19);
            label3.TabIndex = 0;
            label3.Text = "Total Produk";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(504, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 71);
            panel5.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(3, 38);
            label7.Name = "label7";
            label7.Size = new Size(42, 19);
            label7.TabIndex = 2;
            label7.Text = "450";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(141, 19);
            label4.TabIndex = 2;
            label4.Text = "Total Penjualan";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(751, 123);
            panel6.Name = "panel6";
            panel6.Size = new Size(216, 71);
            panel6.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(3, 38);
            label8.Name = "label8";
            label8.Size = new Size(131, 19);
            label8.TabIndex = 3;
            label8.Text = "Rp. 3.450.000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 13);
            label5.Name = "label5";
            label5.Size = new Size(162, 19);
            label5.TabIndex = 3;
            label5.Text = "Total Penghasilan";
            // 
            // btnTambahProduk
            // 
            btnTambahProduk.BackColor = Color.DarkGreen;
            btnTambahProduk.Cursor = Cursors.Hand;
            btnTambahProduk.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahProduk.ForeColor = Color.White;
            btnTambahProduk.ImageAlign = ContentAlignment.MiddleLeft;
            btnTambahProduk.Location = new Point(1054, 135);
            btnTambahProduk.Name = "btnTambahProduk";
            btnTambahProduk.Size = new Size(181, 45);
            btnTambahProduk.TabIndex = 4;
            btnTambahProduk.Text = "Tambah Produk";
            btnTambahProduk.UseVisualStyleBackColor = false;
            btnTambahProduk.Click += btnTambahProduk_Click;
            // 
            // btnRefreshData
            // 
            btnRefreshData.BackColor = Color.DarkGreen;
            btnRefreshData.Cursor = Cursors.Hand;
            btnRefreshData.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshData.ForeColor = Color.White;
            btnRefreshData.Image = Properties.Resources.dashboard_icon;
            btnRefreshData.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefreshData.Location = new Point(12, 161);
            btnRefreshData.Name = "btnRefreshData";
            btnRefreshData.Size = new Size(181, 45);
            btnRefreshData.TabIndex = 4;
            btnRefreshData.Text = "refreshData";
            btnRefreshData.UseVisualStyleBackColor = false;
            btnRefreshData.Click += btnRefreshData_Click;
            // 
            // AdminDashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnTambahProduk);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboardView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboardView";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Button btnDashboard;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label label_totalProduk;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private Label label7;
        private Label label8;
        private Label label5;
        private Panel panel8;
        private Label label10;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Label label12;
        private Label label11;
        private Button btnTambahProduk;
        private Button btnRefreshData;
    }
}