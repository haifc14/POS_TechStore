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
    public partial class SingInForm : Form
    {
        public int UserName { get; private set; }
        public int Password { get; private set; }
        public bool IsAuthenticated { get; private set; }
        Employee employee;

        public SingInForm()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string usernameInput = UserNameTextbox.Text;
            string passwordInput = PasswordTextbox.Text;

            if (IsValidInput(usernameInput) && IsValidInput(passwordInput))
            {
                UserName = int.Parse(usernameInput);
                Password = int.Parse(passwordInput);

                employee = new Employee(UserName, Password);

                IsAuthenticated = employee.IsAuthenticated();         

                if (IsAuthenticated)
                {
                    POSForm posForm = new POSForm();
                    this.Close();
                    posForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong credentials. Try again...");
                }
            }
            else
            {
                MessageBox.Show("Invalid username / password input. Try again...");
            }
            
        }

        /// <summary>
        /// This method is to check if user input a number or not.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool IsValidInput(string input)
        {
            bool isInputValid = int.TryParse(input, out int validInput);

            if (isInputValid)
            {
                return true;
            }

            return false;
        }
    }
}
