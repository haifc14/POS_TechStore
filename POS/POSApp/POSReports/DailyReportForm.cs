﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLibrary;
using System.IO;

namespace POSApp
{
    public partial class DailyReportForm : Form
    {
        public decimal StartingCash { get; private set; }
        public decimal ActualCashInTill { get; private set; }
        public DateTime CurrentDate { get; private set; }
        public int TotalOrder { get; private set; }
        public int TotalItems { get; private set; }
        public decimal TotalIncomeByCard { get; private set; }
        public decimal TotalIncomeByCash { get; private set; }
        public decimal TotalReedemsPoints { get; private set; }
        public decimal TotalIncome { get; private set; }
        public decimal Variance { get; private set; }

        public DailyReportForm(decimal startingCash, decimal actualCashInTill)
        {
            InitializeComponent();
            StartingCash = startingCash;
            ActualCashInTill = actualCashInTill;
            CurrentDate = DateTime.UtcNow.Date;
            TotalOrder = Helper.GetTotalOrdersOfCurrentDay(CurrentDate);
            TotalItems = Helper.GetTotalItemsOfCurrentDay(CurrentDate);
            TotalIncomeByCard = Helper.GetTotalIncomeByCardOfCurrentDay(CurrentDate);
            TotalIncomeByCash = Helper.GetTotalIncomeByCashOfCurrentDay(CurrentDate);
            TotalReedemsPoints = GetTotalRedeemPoints(CurrentDate);
            TotalIncome = Helper.GetTotalIncomeOfCurrentDay(CurrentDate);
            Variance = GetVariance();
            DisplayReportData();
            this.ControlBox = false;
        }

        private decimal GetTotalRedeemPoints(DateTime currentDate)
        {
            // get total points
            int totalpoints = Helper.GetTotalRedeemPointsOfCurrentDay(currentDate);
            // convert to money
            decimal moneyCalculatedfromTotalPoints = totalpoints / 1000;
            return moneyCalculatedfromTotalPoints;
        }
        
        private decimal GetVariance()
        {
            // get total cash from db minus (actual cash in till - starting cash)
            var variance = TotalIncomeByCash - (ActualCashInTill - StartingCash);
            return variance;
        }

        //showing calculated values on form
        private void DisplayReportData()
        {
            labelCurrentDate.Text = CurrentDate.ToLongDateString();
            labelTotalOrders.Text = TotalOrder.ToString() + " orders.";
            labelTotalItems.Text = TotalItems.ToString() + " items.";
            labelTotalByCard.Text = "$ " + TotalIncomeByCard.ToString();
            labelTotalByCash.Text = "$ " + TotalIncomeByCash.ToString();
            labelTotalRedeems.Text = "$ " + TotalReedemsPoints.ToString();
            labelTotalIncome.Text = "$ " + TotalIncome.ToString();
            labelStartingCash.Text = "$ " + StartingCash.ToString();
            labelTotalActualTillIncome.Text = "$ " + ActualCashInTill.ToString();
            labelVariance.Text = "$ " + Variance.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form item in Application.OpenForms)
            {
                item.Show();
            }
        }

        //exporting file in debug folder
        private void btnExportData_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Helper.FILE_PATH_DAYEND_REPORT))
                {
                    writer.WriteLine("\t\t\t" + "--------DAY END SUMMARY REPORT-----------");
                    writer.WriteLine("\t" + "Date: " + CurrentDate.ToLongDateString());
                    writer.WriteLine("\t" + "Total Orders: " + TotalOrder.ToString());
                    writer.WriteLine("\t" + "Total Items: " + TotalItems.ToString());
                    writer.WriteLine("\t" + "Total Income By Card: " + TotalIncomeByCard.ToString());
                    writer.WriteLine("\t" + "Total Income By Cash: " + TotalIncomeByCash.ToString());
                    writer.WriteLine("\t" + "Total Redeems Fee: " + TotalReedemsPoints.ToString());
                    writer.WriteLine("\t" + "Total Income: " + TotalIncome.ToString());
                    writer.WriteLine("\t" + "Variance: " + Variance.ToString());
                }
                MessageBox.Show("Day end report is saved successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("The report isn't saved successfully. Try again.");
            }
            
        }

        //printing document
        private void printDayEndReportDocs_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            g.DrawString("\tDay End Summary Report", font, brush, x, y);
            g.DrawString("\t--------------------------------------", font, brush, x, y += nxtLineIncrement);

            g.DrawString("\tDate : " + currentDate.ToLongDateString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("\tTotal Orders : " + TotalOrder.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("\tTotal Items : " + TotalItems.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("\tTotal Income By Card : " + TotalIncomeByCard.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("\tTotal Income By Cash : " + TotalIncomeByCash.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("\tTotal Redeem Points Fee : " + TotalReedemsPoints.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("\tTotal Income : " + TotalIncome.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("\tStarting Cash : " + StartingCash.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("\tTotal Till Balance : " + ActualCashInTill.ToString(), font, brush, x, y += nxtLineIncrement);
            g.DrawString("\tVariance : " + Variance.ToString(), font, brush, x, y += nxtLineIncrement);
                     
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDayEndReportDocs.Print();
        }
    }
}
