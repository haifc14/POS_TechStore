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
using System.IO;

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
            ProductViewControl.ScanBarcode = OrderControl.ScanProduct;
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
                try
                {
                    _lastOrder = new Order(finalizeForm.CurrentOrder.OrderNumber);
                }
                catch
                {
                    _lastOrder = null;
                }
                

                //remove last order and add new one
                this.Controls.Remove(this.OrderControl);
                this.OrderControl = new OrderControl();
                ProductViewControl.ScanBarcode = this.OrderControl.ScanProduct;
                this.Controls.Add(this.OrderControl);

                //close finalizeform to continue on new order
                finalizeForm.Close();
            };
        }

        /// <summary>
        /// This event is to confirm and finalize the current order
        /// calculate the order and show the change if it has
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        /// <summary>
        /// This event is to print the summary data of last order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintLastOrderBtn_Click(object sender, EventArgs e)
        {
            if (this._lastOrder == null || this._lastOrder.Customer == null)
            {
                MessageBox.Show("No order available to print!");
            }
            else
            {
                PrintReceiptDocument.Print();
            }
        }

        /// <summary>
        /// This event is to print the invoice of the current order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintReceiptDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int nxtLineIncrement = 20;
            Graphics g = e.Graphics;
            var font = new Font("Arial", 16);
            var brush = new SolidBrush(Color.Black);
            g.DrawString("Order summary", font, brush, x, y);
            g.DrawString("-------------------------------------------------", font, brush, x, y += nxtLineIncrement);
            g.DrawString("ProductName \t\t price", font, brush, x, y += nxtLineIncrement);
            g.DrawString("-------------------------------------------------", font, brush, x, y += nxtLineIncrement);
            foreach (var item in _lastOrder.ListOfItems)
            {
                // display each item within the order
                g.DrawString(item.Name + "\t\t" + item.Price, font, brush, x, y += nxtLineIncrement);
                g.DrawString("Discount : " + item.Discount, font, brush, x, y += nxtLineIncrement);
            }
            // display overall detail of order
            g.DrawString("--------------------------------------", font, brush, x, y += nxtLineIncrement);
            g.DrawString("Subtotal : $" + _lastOrder.SubTotal.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("Tax : $" + _lastOrder.Tax.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("TotalDiscount: $" + _lastOrder.TotalDiscount.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("--------------------------------------", font, brush, x, y += nxtLineIncrement);
            g.DrawString("Total $" + _lastOrder.Total.ToString(), font, brush, x, y += nxtLineIncrement);
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
            g.DrawString("Chage Due: "  +( - (_lastOrder.Total - _lastOrder.TotalPaidByCard - _lastOrder.TotalPaidByCash - (_lastOrder.TotalRedeemPoints / Helper.PointsWorthTo1Dollar))).ToString(), font, brush, x, y += nxtLineIncrement);

        }

        /// <summary>
        /// This event is to print the detail of all order of the the working day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DayEndButton_Click_1(object sender, EventArgs e)
        {
            printDayDetailReport.Print();
        }

        private void POSForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// This event is to print the summary data when the day end
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DayReportButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to day close?", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Hide();
                GetCashReportInputForm tillCashInputForm = new GetCashReportInputForm();
                tillCashInputForm.Show();
            }
        }

        //variables to print
        private int _printIndex = 0;
        private int _numberOfRecordPerPage = 3;
        private int _currentPage = 0;

        private void printDayDetailReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.printDayDetailReport.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("papersize", 150, 500);

            DateTime currentDate = DateTime.UtcNow.Date;
            List<TOrder> listOfOrdersWithinCurrentDay = Helper.GetAllOrdersForDayEnd(currentDate);

            int x = e.MarginBounds.Left;
            int y = 0;
            int nxtLineIncrement = 20;
            Graphics g = e.Graphics;
            var font = new Font("Arial", 16);
            var brush = new SolidBrush(Color.Black);
            g.DrawString("Daily Detail Report", font, brush, x, y += nxtLineIncrement);
            while (_printIndex < listOfOrdersWithinCurrentDay.Count)
            {
                var order = listOfOrdersWithinCurrentDay[_printIndex];
               
                g.DrawString("--------------------------------------", font, brush, x, y += nxtLineIncrement);
                int employeeIdForEachOrder = (int)order.EmployeeID;
                g.DrawString(Helper.GetEmployeeNameFromOrderReport(employeeIdForEachOrder).ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("\tOrder Number : " + order.OrderNumber.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("\tTotal Price : " + order.TotalPrice.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("\tTotal Discount : " + order.TotalDiscount.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("\tTotal Tax : " + order.TotalTax.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("\tTotal CardPayment : " + order.CardPayment.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("\tTotal CashPayment : " + order.CashPayment.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("\tTotal Points Redeem : " + order.PoitRedeem.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("\tTotal Points Earned : " + order.PointEarned.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("\tCustomerID : " + order.CustomerID.ToString(), font, brush, x, y += nxtLineIncrement);
                g.DrawString("--------------------------------------", font, brush, x, y += nxtLineIncrement);
                _printIndex++;
                _currentPage++;
                if (_currentPage > _numberOfRecordPerPage && _printIndex < listOfOrdersWithinCurrentDay.Count)
                {
                    _currentPage = 0;
                    y = 0;
                    e.HasMorePages = true;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // if items are already added in order show error
            if (this.OrderControl.CurrentOrder.ListOfItems.Count > 0)
            {
                MessageBox.Show("Finish current order first. or abort transaction!");
            }
            else
            {
                this.OrderControl.CurrentOrder.VoidTransaction();
                this.OrderControl.OrderType = "---------Void Transaction-----------";
            }
        }

    }
}
