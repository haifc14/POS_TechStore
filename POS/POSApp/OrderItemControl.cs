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
    public partial class OrderItemControl : UserControl
    {

        public string ItemBarcode
        {
            get { return ItemBarcodeLabel.Text; }
            set
            {
                ItemBarcodeLabel.Text = value.ToString();
            }
        }

        public string ItemName
        {
            get { return ItemNameLabel.Text; }
            set
            {
                ItemNameLabel.Text = value.ToString();
            }
        }

        public string ItemPrice
        {
            get { return ItemPriceLabel.Text; }
            set
            {
                ItemPriceLabel.Text = value.ToString();
            }
        }

        public OrderItemControl()
        {
            InitializeComponent();
        }
    }
}
