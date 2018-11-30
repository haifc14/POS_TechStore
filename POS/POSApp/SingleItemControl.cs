using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApp
{
    public partial class SingleItemControl : UserControl
    {

        private string _barcode;

        public string Barcode
        {
            get { return BarcodeLabel.Text; }
            set { BarcodeLabel.Text = value.ToString(); }
        }

        private string _productName;

        public  string ProductName
        {
            get { return ProductNameLabel.Text; }
            set { ProductNameLabel.Text = value.ToString(); }
        }

        private string _productPrice;
        public string ProductPrice
        {
            get { return ProductPriceLabel.Text; }
            set { ProductPriceLabel.Text = value.ToString(); }
        }

        public SingleItemControl()
        {
            InitializeComponent();
        }
    }
}
