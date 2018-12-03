using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLibrary;

namespace POSApp
{
    public partial class FinalizeOrderForm : Form
    {
        private Order CurruntOrder;

        public bool OrderComplete = false;

        public FinalizeOrderForm(Order curruntOrder)
        {
            InitializeComponent();
            this.CurruntOrder = curruntOrder;
            AddProductsToOrderSummaryPanel();
        }

        private void FinalizeOrderForm_Load(object sender, EventArgs e)
        {
            if (CurruntOrder.ListOfItems.Count == 0)
            {
                MessageBox.Show("No item added in Order!");
                this.Close();
            }
        }

        private void AddProductsToOrderSummaryPanel()
        {
            foreach (var item in CurruntOrder.ListOfItems)
            {
                Label label = new Label()
                {
                    Width = this.OrderSummaryPanel.Width,
                    Text = item.Name + "  " + item.Price
                };
                this.OrderSummaryPanel.Controls.Add(label);
            }
        }

        private void FinalizeOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            CompleteOrderTransaction();
        }

        

        private void CompleteOrderTransaction()
        {
            decimal employeeDiscount = 0;
            decimal.TryParse(OrderDiscountControl.UserInput, out employeeDiscount);
            decimal TotalMoneyPaidByCash = 0;
            decimal.TryParse(CashPaymentControl.UserInput, out TotalMoneyPaidByCash);
            decimal TotalMoneyPaidByCard = 0;
            decimal.TryParse(CardPaymentControl.UserInput, out TotalMoneyPaidByCard);
            int TotalRedeemPoints = 0;
            int.TryParse(RedeemPointControl.UserInput, out TotalRedeemPoints);
            try
            {
                CurruntOrder.AddEmployeeDiscount(employeeDiscount);
                CurruntOrder.PayByCard(TotalMoneyPaidByCard);
                CurruntOrder.PayByCash(TotalMoneyPaidByCash);
                CurruntOrder.ReedemPoints(TotalRedeemPoints);
                var change = CurruntOrder.GetBalanceDue();
                MessageBox.Show("Change : " + change.ToString());
                if (change >= 0)
                {
                    CurruntOrder.EarnPoints();
                    CurruntOrder.SaveOrderToDatabase();
                    CurruntOrder.SaveOrderToDatabase();
                    CurruntOrder = null;
                    OrderComplete = true;                   
                    this.Close();
                }
        }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
}
    }
}
