using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLibrary;

namespace POSApp
{
    public partial class OrderItemControl : UserControl
    {
        //event to remove orderItemFrom OrderControl
        public event Action<Product, OrderItemControl> RemoveItemEvent;

        private Product product;

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

        public OrderItemControl(Product scannedItem)
        {
            InitializeComponent();
            product = scannedItem;         
            this.ItemNameLabel.Text = product.Name;
            this.ItemPriceLabel.Text = product.Price.ToString();
        }

        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            RemoveItemEvent(product, this);
        }
    }
}
