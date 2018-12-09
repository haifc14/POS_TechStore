using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSApp
{
    public partial class GetCashReportInputForm : Form
    {
        public GetCashReportInputForm()
        {
            InitializeComponent();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            // get inputs for starting cash and total cash in till

            bool isValidstartingCash = decimal.TryParse(textBoxStartingCash.Text, out decimal validStartingCash);
            bool isValidTotalCashInTill = decimal.TryParse(textBoxTotalCashInTill.Text, out decimal validTotalCashInTillCash);

            if (isValidstartingCash && isValidTotalCashInTill)
            {
                // valid inputs
                DailyReportForm dailyReport = new DailyReportForm(validStartingCash, validTotalCashInTillCash);
                dailyReport.Show();
                this.Close();
            }
            else
            {
                // invalid inputs
                MessageBox.Show("Invalid cash input. Please try again..", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
