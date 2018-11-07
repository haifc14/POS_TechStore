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

        private void SubmitBarcodeBtn_Click(object sender, EventArgs e)
        {
            // This event is to get Product info based on Barcode 
            // and show Product info to the Ordered List

            MessageBox.Show("Get Product info");
        }
    }
}
