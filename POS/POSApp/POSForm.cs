using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLibrary;
using System.Configuration;
using System.Data.Objects;
using System.Data.SqlClient;

namespace POSApp
{
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
        }
        
        private void PosForm_Load(object sender, EventArgs e)
        {
            var brands = Helper.GetBrands();
            brands.Insert(0, "Select by Brand");
            var category = Helper.GetCategories();
            category.Insert(0, "Select by Category");
            BrandComboBox.DataSource = brands;
            CategoryComboBox.DataSource = category;
        }

        /// <summary>
        ///  This event is to get Product info based on Barcode 
        ///  and show Product info to the Ordered List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitBarcodeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("knkn");
            try
            {
                string barcodeFromInput = BarcodeTextBox.Text;
                // Get Scanned Product info 
                Product product = new Product(barcodeFromInput);
                
                // display that product on Left Product Panel
                Label productInfoLabel = new Label();

                string productBarcode = product.Barcode.ToString();
                string productName = product.Name;
                string productPrice = product.Price.ToString();

                productInfoLabel.Width = OrderView_Panel.Width;

                productInfoLabel.Text = productBarcode.PadRight(6) + productName.Replace(" ","") + "  " + productPrice.PadLeft(6);

                OrderView_Panel.Controls.Add(productInfoLabel);
            }
            catch (Exception)
            {
                MessageBox.Show("The item is not exists!!!");              
            }
            BarcodeTextBox.Text = "";

        }

        private void SignOff_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void FilterSubmitBtn_Click(object sender, EventArgs e)
        {
            var keywords = SearchTextBox.Text;
            var brandName = BrandComboBox.Items[BrandComboBox.SelectedIndex].ToString();
            var categoryName = CategoryComboBox.Items[CategoryComboBox.SelectedIndex].ToString();
            var productCollection = new ProductCollection(keywords, brandName, categoryName);
        }
    }
}
