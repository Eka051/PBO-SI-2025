using MarketplaceWinform.Helpers;
using MarketplaceWinform.Interfaces;
using MarketplaceWinform.Models;

namespace MarketplaceWinform.Views.Admin
{
    public partial class AdminDashboardView : Form
    {
        private IProduct productController;
        public AdminDashboardView(IProduct productInterface)
        {
            InitializeComponent();
            productController = productInterface;
            LoadProducts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        public Panel CreateProductPanel(Product product)
        {
            Panel panel = new Panel
            {
                Size = new Size(334, 134),
                Margin = new Padding(3),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.card_product,
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            PictureBox displayProduct = new PictureBox
            {
                Location = new Point(12, 18),
                Size = new Size(100, 96),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            displayProduct.Image = ImageHelper.BinaryToImage(product.Image);

            Label namaProduk = new Label
            {
                Text = product.ProductName,
                Location = new Point(118, 18),
                Size = new Size(128, 19),
                BackColor = Color.Transparent,
                Font = new Font("Inter", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label hargaProduk = new Label
            {
                Text = product.Price.ToString(),
                Location = new Point(118, 43),
                Size = new Size(131, 19),
                BackColor = Color.Transparent,
                ForeColor = Color.Green,
                Font = new Font("Inter", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label stokProduk = new Label
            {
                Text = product.Stock.ToString(),
                Location = new Point(118, 65),
                Size = new Size(108, 19),
                BackColor = Color.Transparent,
                ForeColor = Color.DarkGray,
                Font = new Font("Inter", 12, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Button buttonEdit = new Button
            {
                Location = new Point(118, 91),
                Size = new Size(120, 23),
                Font = new Font("Inter", 10, FontStyle.Regular),
                BackColor = Color.White,
                Text = "Edit"
            };
            //buttonEdit.Click += (sender, e) => productController.EditProduct();

            Button buttonHapus = new Button
            {
                Location = new Point(244, 91),
                Size = new Size(72, 23),
                Font = new Font("Inter", 10, FontStyle.Regular),
                BackColor = Color.Red,
                ForeColor = Color.White,
                Text = "Hapus"
            };
            buttonHapus.Click += (sender, e) => productController.GetAllProduct();

            panel.Controls.Add(displayProduct);
            panel.Controls.Add(namaProduk);
            panel.Controls.Add(hargaProduk);
            panel.Controls.Add(stokProduk);
            panel.Controls.Add(buttonEdit);
            panel.Controls.Add(buttonHapus);

            return panel;
        }

        public void LoadProducts()
        {
            flowLayoutPanel1.Controls.Clear();

            List<Product> products = productController.GetAllProduct();

            foreach (Product product in products)
            {
                Panel panelProduk = CreateProductPanel(product);
                flowLayoutPanel1.Controls.Add(panelProduk);
            }
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            AddProductView tambahProduk = new AddProductView();
            tambahProduk.Show();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
