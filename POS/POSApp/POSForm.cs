using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApp
{
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            // Get input of Barcode

            bool isBarcodeValid = int.TryParse(BarcodeTextBox.Text, out int validBarcode);

            if (!isBarcodeValid)
            {
                MessageBox.Show("Invalid BarCode! Please enter again");
            }

            // Get List of Products from DB


            // Retrieve a list of Product that match the barcode

            // Return one of the Product from that list

            // Display that product to Order list

        }
    }
}
