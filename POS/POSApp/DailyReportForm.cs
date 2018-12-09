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
    }
}
