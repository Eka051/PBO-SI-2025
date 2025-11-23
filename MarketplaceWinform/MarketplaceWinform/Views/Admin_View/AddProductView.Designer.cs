namespace MarketplaceWinform.Views.Admin
{
    partial class AddProductView
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
            openFileDialog1 = new OpenFileDialog();
            btnUpload = new Button();
            tbProductName = new TextBox();
            tbPrice = new TextBox();
            tbStock = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gambarProduk = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gambarProduk).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.ForestGreen;
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(316, 121);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(135, 37);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload Gambar";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(289, 211);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(187, 23);
            tbProductName.TabIndex = 1;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(289, 256);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(187, 23);
            tbPrice.TabIndex = 2;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(289, 306);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(187, 23);
            tbStock.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(316, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 37);
            btnSave.TabIndex = 4;
            btnSave.Text = "SIMPAN";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 193);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Nama Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 238);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 6;
            label2.Text = "Harga Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 288);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 7;
            label3.Text = "Stok Produk";
            // 
            // gambarProduk
            // 
            gambarProduk.BackgroundImageLayout = ImageLayout.Zoom;
            gambarProduk.Location = new Point(332, 24);
            gambarProduk.Name = "gambarProduk";
            gambarProduk.Size = new Size(100, 91);
            gambarProduk.TabIndex = 8;
            gambarProduk.TabStop = false;
            // 
            // AddProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(gambarProduk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(tbStock);
            Controls.Add(tbPrice);
            Controls.Add(tbProductName);
            Controls.Add(btnUpload);
            Name = "AddProductView";
            Text = "AddProductView";
            ((System.ComponentModel.ISupportInitialize)gambarProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button btnUpload;
        private TextBox tbProductName;
        private TextBox tbPrice;
        private TextBox tbStock;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox gambarProduk;
    }
}