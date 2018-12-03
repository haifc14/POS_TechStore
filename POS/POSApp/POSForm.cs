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


        public Action<FinalizeOrderForm> ClearCurruntOrder()
        {
            return finalizeForm => 
            {
                this.Controls.Remove(this.OrderControl);
                this.OrderControl = new OrderControl();
                this.Controls.Add(this.OrderControl);
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

        }

        private void OrderControl_Load(object sender, EventArgs e)
        {

        }
    }
}
