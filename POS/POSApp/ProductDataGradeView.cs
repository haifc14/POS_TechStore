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
    public partial class ProductViewControl : UserControl
    {
        public ProductViewControl()
        {
            InitializeComponent();
        }

        public void UpdateSource(List<Product> products)
        {
            foreach (var product in products)
            {
                var label = new Label()
                {
                    Width = ProductsViewPanel.Width,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Text = product.ToString()
                };
                ProductsViewPanel.Controls.Add(label);
            }            
        }
    }
}
