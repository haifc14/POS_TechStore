﻿using System;
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
        private Employee employee;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string usernameInput = UserNameTextbox.Text;
            string passwordInput = PasswordTextbox.Text;

            try
            {
                employee = new Employee(usernameInput, passwordInput);

                int returnedEmployeeID = employee.GetEmployeeID();
                if (returnedEmployeeID > 0)
                {
                    POSForm posForm = new POSForm(returnedEmployeeID);
                    posForm.Show();
                    this.Close();
                }
            }
            catch (Exception egf) 
            {
                MessageBox.Show(egf.Message);
                MessageBox.Show("Invalid username and password. Try again...");
                UserNameTextbox.Text = "";
                PasswordTextbox.Text = "";
            }                    
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //pictureBoxLoginPhoto.Image = Image.FromFile("../../../Images/loginPhoto.jpg");
        }
    }
}
