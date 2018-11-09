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

namespace POSApp
{
    public partial class SingInForm : Form
    {
        public SingInForm()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var posForm = new POSForm();
            this.Close();
            posForm.Show();
        }
    }
}
