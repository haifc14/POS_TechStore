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
    public partial class OrderPaymentOptionControl : UserControl
    {


        public string LabelName
        {
            get
            {
                return PaymentTypeLabel.Text;
            }
            set
            {
                PaymentTypeLabel.Text = value;
            }
        }

        public string UserInput
        {
            get
            {
                return PaymentTypeTextbox.Text;
            }
            set
            {
                PaymentTypeTextbox.Text = value;
            }
        }

        public string CurrencySign
        {
            get
            {
                return CurrencyLable.Text;
            }
            set
            {
                CurrencyLable.Text = value;
            }
        }


        public OrderPaymentOptionControl()
        {
            InitializeComponent();
        }
    }
}
