﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLibrary;

namespace POSApp
{
    public class LoginViewControl
    {
        public TextBox UserNameTextbox { get; set; }
        public TextBox PwdTextBox { get; set; }
        public Button SubmitButton { get; set; }

        public bool OnLoginSubmit()
        {
            //event
            //triggers when login submit clicked
            throw new NotImplementedException();
        }
    }
}