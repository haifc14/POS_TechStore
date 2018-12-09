﻿using System;
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
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
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
            g.DrawString("Chage Due: " + _lastOrder.GetBalanceDue().ToString(), font, brush, x, y += nxtLineIncrement);

        }


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

        private void printDayDetailReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //DateTime currentDate = DateTime.UtcNow.Date;
            DateTime currentDate = DateTime.Parse("2018-12-09 20:44:02.3033333"); // for testing           
            List<TOrder> listOfOrdersWithinCurrentDay = Helper.GetAllOrdersForDayEnd(currentDate);

            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int nxtLineIncrement = 20;
            Graphics g = e.Graphics;
            var font = new Font("Arial", 16);
            var brush = new SolidBrush(Color.Black);
            g.DrawString("Daily Detail Report", font, brush, x, y);
            g.DrawString("--------------------------------------", font, brush, x, y += nxtLineIncrement);
            foreach (TOrder order in listOfOrdersWithinCurrentDay)
            {
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
