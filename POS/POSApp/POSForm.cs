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
            
        }

        /// <summary>
        ///  This event is to get Product info based on Barcode 
        ///  and show Product info to the Ordered List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitBarcodeBtn_Click(object sender, EventArgs e)
        {
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

    }
}
