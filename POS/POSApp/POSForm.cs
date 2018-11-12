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

            string barcodeFromInput = BarcodeTextBox.Text;

            try
            {
                Product product = new Product(barcodeFromInput);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);              
            }
            BarcodeTextBox.Text = "";

        }
    }
}
