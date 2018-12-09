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
       

        public POSForm(int employeeId)
        {
            InitializeComponent();

            EmployeeID = employeeId;
        }
        
        private void PosForm_Load(object sender, EventArgs e)
        {
            this.OrderControl.EmployeeId = this.EmployeeID;
        }
      
        private void SignOff_Button_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void FinalizeOrderButton_Click(object sender, EventArgs e)
        {
            FinalizeOrderForm finalizeForm = new FinalizeOrderForm(this.OrderControl.CurrentOrder);
            finalizeForm.ShowDialog();
        }

        private void ScanLoyaltyButton_Click(object sender, EventArgs e)
        {

        }

        private void DayEndButton_Click(object sender, EventArgs e)
        {          
            DateTime currentDate = DateTime.UtcNow.Date;
            //DateTime currentDate = DateTime.Parse("2018-12-02 20:44:02.3033333"); // for testing           
            List<TOrder> listOfOrdersWithinCurrentDay = Helper.GetAllOrdersForDayEnd(currentDate);
            try
            {
                // write data to dayend txt file
                using (StreamWriter sw = new StreamWriter(Helper.FILE_PATH_DAYEND))
                {
                    sw.WriteLine("\t\t\t\t" + "------------ DAY END REPORT-------------");
                    sw.WriteLine("\n");
                    sw.WriteLine("Date: " + currentDate.ToLongDateString());
                    sw.WriteLine("\n");

                    foreach (var order in listOfOrdersWithinCurrentDay)
                    {

                        int employeeIdForEachOrder = (int)order.EmployeeID;
                        sw.WriteLine("\t" + Helper.GetEmployeeNameFromOrderReport(employeeIdForEachOrder));
                        sw.WriteLine("\t\t Order Number: " + order.OrderNumber.ToString());
                        sw.WriteLine("\t\t Total Price: " + order.TotalPrice.ToString());
                        sw.WriteLine("\t\t Total Discount: " + order.TotalDiscount.ToString());
                        sw.WriteLine("\t\t Total Tax: " + order.TotalTax.ToString());
                        sw.WriteLine("\t\t Total CardPayment: " + order.CardPayment.ToString());
                        sw.WriteLine("\t\t Total CashPayment: " + order.CashPayment.ToString());
                        sw.WriteLine("\t\t Total Points Redeem: " + order.PoitRedeem.ToString());
                        sw.WriteLine("\t\t Total Points Earned: " + order.PointEarned.ToString());
                        sw.WriteLine("\t\t CustomerID: " + order.CustomerID.ToString());
                        sw.WriteLine("\n");
                    }

                    MessageBox.Show("DayEnd has been exported successfully", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Day report falis. Contact admin to get help..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void DayReportButton_Click(object sender, EventArgs e)
        {

            // popup the form to get input for starting cash and total cash in till from user

            GetCashReportInputForm cashInputForm = new GetCashReportInputForm();

            cashInputForm.ShowDialog();

            //DateTime currentDate = DateTime.UtcNow.Date;
            DateTime currentDate = DateTime.Parse("2018-12-02 20:44:02.3033333"); // for testing

            // Get summary of total income from all orders from system including card and cash for a day
            decimal totalIncomeOfCurrentDayFromSystem = Helper.GetTotalIncomeOfCurrentDay(currentDate);

            decimal totalIncomeOfCurrentDayByCard = Helper.GetTotalIncomeByCardOfCurrentDay(currentDate);
           
            decimal totalIncomeOfCurrentDayByCash = Helper.GetTotalIncomeByCashOfCurrentDay(currentDate);

            int totalOrdersOfCurrentDay = Helper.GetTotalOrdersOfCurrentDay(currentDate);

            
            
            // Open a report form to let cashier input the actual money when the end of day
            // then export the differnece between income from system versus actual inconme of current day

            
        }

        private void POSForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }
    }
}
