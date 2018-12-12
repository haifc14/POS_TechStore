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
        public Order CurrentOrder;

        private event Action<FinalizeOrderForm> CloseCurrentOrder;

        public FinalizeOrderForm(Order curruntOrder, Action<FinalizeOrderForm> closeCurrentOrder)
        {
            InitializeComponent();
            this.CurrentOrder = curruntOrder;
            this.CloseCurrentOrder = closeCurrentOrder;
            AddProductsToOrderSummaryPanel();
            AddOrderSummaryInfoToSummaryPanel();
        }

        private void FinalizeOrderForm_Load(object sender, EventArgs e)
        {
            if (CurrentOrder.ListOfItems.Count == 0)
            {
                MessageBox.Show("No item added in Order!");
                this.Close();
            }
        }

        private void AddProductsToOrderSummaryPanel()
        {
            foreach (var item in CurrentOrder.ListOfItems)
            {
                Label label = new Label()
                {
                    Width = this.OrderSummaryPanel.Width,
                    Text = item.Name + "  " + item.Price,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                };
                this.OrderSummaryPanel.Controls.Add(label);
            }
        }

        private void AddOrderSummaryInfoToSummaryPanel()
        {
            Label label = new Label()
            {
                Width = this.OrderSummaryPanel.Width,
                Font = new Font("Arial", 14, FontStyle.Bold),
            };
            this.OrderSummaryPanel.Controls.Add(label);
            label = new Label()
            {
                Width = this.OrderSummaryPanel.Width,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Text = "--------------------------------------------",
            };
            this.OrderSummaryPanel.Controls.Add(label);
            label = new Label()
            {
                Width = this.OrderSummaryPanel.Width,
                Text = "Subtotal " + CurrentOrder.SubTotal.ToString(),
                Font = new Font("Arial", 14, FontStyle.Bold),
            };
            this.OrderSummaryPanel.Controls.Add(label);
            label = new Label()
            {
                Width = this.OrderSummaryPanel.Width,
                Text = "Discount " + CurrentOrder.Discount.ToString(),
                Font = new Font("Arial", 14, FontStyle.Bold),
            };
            this.OrderSummaryPanel.Controls.Add(label);
            label = new Label()
            {
                Width = this.OrderSummaryPanel.Width,
                Text = "Tax "+ CurrentOrder.Tax.ToString(),
                Font = new Font("Arial", 14, FontStyle.Bold),
            };
            this.OrderSummaryPanel.Controls.Add(label);
            label = new Label()
            {
                Width = this.OrderSummaryPanel.Width,
                Text = "Total " + CurrentOrder.Total.ToString(),
                Font = new Font("Arial", 14, FontStyle.Bold),
            };
            this.OrderSummaryPanel.Controls.Add(label);
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
                CurrentOrder.AddEmployeeDiscount(employeeDiscount);
                CurrentOrder.PayByCard(TotalMoneyPaidByCard);
                CurrentOrder.PayByCash(TotalMoneyPaidByCash);
                CurrentOrder.ReedemPoints(TotalRedeemPoints);
                var change = CurrentOrder.GetBalanceDue();
                MessageBox.Show("Change Due: " + change.ToString());
                if (change >= 0)
                {
                    CurrentOrder.SaveOrderToDatabase();
                    this.CloseCurrentOrder(this);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
}

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            CloseCurrentOrder(this);
        }
    }
}
