using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.EntityClient;
using POSLibrary;

namespace POSApp
{
    public partial class LoginForm : Form
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public bool IsAuthenticated { get; private set; }
        Employee employee;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string usernameInput = UserNameTextbox.Text;
            string passwordInput = PasswordTextbox.Text;

            employee = new Employee(usernameInput, passwordInput);

            int returnedEmployeeID = employee.GetEmployeeID(); 

            if (returnedEmployeeID > 0)
            {
                POSForm posForm = new POSForm(returnedEmployeeID);
                this.Close();
                posForm.Show();
            }
            else
            {
                MessageBox.Show("Wrong credentials. Try again...");
                UserNameTextbox.Text = "";
                PasswordTextbox.Text = "";
            }
        }
        
    }
}
