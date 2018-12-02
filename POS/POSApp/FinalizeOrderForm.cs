﻿using System;
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
    public partial class FinalizeOrderForm : Form
    {
        private Order CurruntOrder;

        public FinalizeOrderForm(Order curruntOrder)
        {
            InitializeComponent();
            this.CurruntOrder = curruntOrder;
            AddProductsToOrderSummaryPanel();
        }

        private void AddProductsToOrderSummaryPanel()
        {
            foreach (var item in CurruntOrder.ListOfItems)
            {
                Label label = new Label()
                {
                    Width = this.OrderSummaryPanel.Width,
                    Text = item.Name + "  " + item.Price
                };
                this.OrderSummaryPanel.Controls.Add(label);
            }
        }

        private void FinalizeOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void CompleteOrderButton_Click(object sender, EventArgs e)
        {
            //CurruntOrder.Discount
        }


    }
}