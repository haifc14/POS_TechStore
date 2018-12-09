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
        readonly int EmployeeID;
        private Order _lastOrder;
       

        public POSForm(int employeeId)
        {
            InitializeComponent();
            EmployeeID = employeeId;
        }
        
        private void PosForm_Load(object sender, EventArgs e)
        {
            this.OrderControl.EmployeeId = this.EmployeeID;
        }


        public Action<FinalizeOrderForm> ClearCurruntOrder()
        {
            return finalizeForm => 
            {
                //save last order so employee can print receipt
                _lastOrder = finalizeForm.CurrentOrder;

                //remove last order and add new one
                this.Controls.Remove(this.OrderControl);
                this.OrderControl = new OrderControl();
                this.Controls.Add(this.OrderControl);

                //close finalizeform to continue on new order
                finalizeForm.Close();
            };
        }

        private void FinalizeOrderButton_Click(object sender, EventArgs e)
        {
            if (this.OrderControl.CurrentOrder.ListOfItems.Count() != 0)
            {
                FinalizeOrderForm finalizeForm = new FinalizeOrderForm(this.OrderControl.CurrentOrder, ClearCurruntOrder());
                finalizeForm.ShowDialog();
            }
        }

        private void SignOff_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void productViewControl1_Load(object sender, EventArgs e)
        {
            // get data from TOrder tabel

            //List<TOrder> listOfOrdersWithinCurrentDay = Helper.GetAllOrdersForDayEnd();

            //foreach (var order in listOfOrdersWithinCurrentDay)
            //{
                
            //}
            
            // write data to txt file
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {

        }

        private void PrintLastOrderBtn_Click(object sender, EventArgs e)
        {
            PrintReceiptDocument.Print();
        }

        private void PrintReceiptDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int nxtLineIncrement = 20;
            Graphics g = e.Graphics;
            var font = new Font("Arial", 16);
            var brush = new SolidBrush(Color.Black);
            g.DrawString("Order summary", font, brush, x, y);
            g.DrawString("--------------------------------------", font, brush, x, y += nxtLineIncrement);
            foreach (var item in _lastOrder.ListOfItems)
            {
                g.DrawString(item.ToString(), font, brush, x, y += nxtLineIncrement);
            }
            g.DrawString("--------------------------------------", font, brush, x, y += nxtLineIncrement);
            g.DrawString("Subtotal : $" + _lastOrder.SubTotal.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("Tax : $" + _lastOrder.Tax.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("TotalDiscount: $" + _lastOrder.TotalDiscount.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("--------------------------------------", font, brush, x, y += nxtLineIncrement);
            g.DrawString("Total $"+_lastOrder.Total.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("-----------------Payment---------------------", font, brush, x, y += nxtLineIncrement);
            g.DrawString("Card Payment: $" + _lastOrder.TotalPaidByCard.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("Cash Payment: $" + _lastOrder.TotalPaidByCash.ToString(), font, brush, x, y += nxtLineIncrement);
            if (_lastOrder.Customer.CustomerId != "-1")
            {
                g.DrawString("Total Points Redeem: " + _lastOrder.TotalRedeemPoints.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("Total Earned Points: " + _lastOrder.Total, font, brush, x, y += nxtLineIncrement);
                g.DrawString("Total Points Left: " + (_lastOrder.Customer.GetPoints()).ToString(),
                                    font, brush, x, y += nxtLineIncrement);
            }
            g.DrawString("--------------------------------------", font, brush, x, y += nxtLineIncrement);
            g.DrawString("Chage Due: " + _lastOrder.GetBalanceDue().ToString(), font, brush, x, y += nxtLineIncrement);

        }
    }
}
