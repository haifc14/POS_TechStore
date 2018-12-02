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
           
        }

        private void DayReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dasjlflkjadfk");
        }
    }
}
