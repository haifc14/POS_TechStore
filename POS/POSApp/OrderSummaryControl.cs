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
    public partial class OrderSummaryControl : UserControl
    {

        public string SubTotal
        {
            get { return SubTotalValueLabel.Text; }
            set
            {
                SubTotalValueLabel.Text = value.ToString();
            }
        }

        public string Tax
        {
            get { return TaxValueLabel.Text; }
            set
            {
                TaxValueLabel.Text = value.ToString();
            }
        }

        public string Discount
        {
            get { return DiscountValueLabel.Text; }
            set
            {
                DiscountValueLabel.Text = value.ToString();
            }
        }

        public string Total
        {
            get { return TotalValueLabel.Text; }
            set
            {
                TotalValueLabel.Text = value.ToString();
            }
        }

        public OrderSummaryControl()
        {
            InitializeComponent();
        }

    }
}
