using MarketplaceWinform.Controllers;
using MarketplaceWinform.Helpers;
using MarketplaceWinform.Interfaces;
using MarketplaceWinform.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarketplaceWinform.Views.Admin
{
    public partial class AddProductView : Form
    {
        private OpenFileDialog openFileDialog;
        private IProduct productController;

        public AddProductView()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            productController = new ProductController();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedItem = openFileDialog.FileName;
                gambarProduk.BackgroundImageLayout = ImageLayout.Zoom;
                gambarProduk.Image = Image.FromFile(selectedItem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openFileDialog.FileName))
            {
                MessageBox.Show("Pilih gambar terlebih dahulu!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Image gambarProduct = gambarProduk.Image;
            string namaProduk = tbProductName.Text;
            int harga = int.Parse(tbPrice.Text);
            int stok = int.Parse(tbStock.Text);

            try
            {
                Product product = new Product 
                {
                    Image = ImageHelper.ImageToBinary(gambarProduct),
                    ProductName = namaProduk,
                    Stock = stok,
                    Price = harga,
                    UserId = AppSession.CurrentUser.UserId,
                };

                productController.CreateProduct(product);
                MessageBox.Show("Produk berhasil ditambahkan", "berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                var adminDashboard = new AdminDashboardView(productController);
                adminDashboard.LoadProducts();
            } catch (Exception ex)
            {
                MessageBox.Show($"Gagal Menambahkan produk {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
