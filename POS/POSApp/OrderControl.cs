using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLibrary;

namespace POSApp
{
    public partial class OrderControl : UserControl
    {
        public Order CurrentOrder { get; set; }
        public int EmployeeId
        {
            get
            {
                return int.Parse(EmployeeIDLabel.Text);
            }
            set
            {
                EmployeeIDLabel.Text = value.ToString();
                CurrentOrder.EmployeeID = value;
            }
        }

        public OrderControl()
        {
            InitializeComponent();
            CurrentOrder = new Order(new List<Product>(), 0 , false);
        }


        /// <summary>
        ///  This event is to get Product info based on Barcode 
        ///  and show Product info to the Ordered List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitBarcodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string barcodeFromInput = BarcodeTextBox.Text;
                // Get Scanned Product info 
                Product scannedItem = new Product(barcodeFromInput);

                // Adding scanned item to a list
                // Then create an order containing all scanned items
                CurrentOrder.AddItem(scannedItem);


                // Binding data of Temporary Order To OrderSummaryControl
                OrderSummaryControl orderSummaryView = new OrderSummaryControl();
                BindingOrderDataToOrderView(CurrentOrder, orderSummaryView);

                // Display Order Info to form
                OrderSummaryFlowPanel.Controls.Clear();
                OrderSummaryFlowPanel.Controls.Add(orderSummaryView);

                // display that product on Left Product Panel
                Label productInfoLabel = new Label();

                string productBarcode = scannedItem.Barcode.ToString();
                string productName = scannedItem.Name;
                string productPrice = scannedItem.Price.ToString();

                productInfoLabel.Width = OrderView_Panel.Width;

                productInfoLabel.Font = new Font(new FontFamily("Arial"), 14, FontStyle.Bold);

                productInfoLabel.Text = productBarcode.PadRight(6) + productName.Replace(" ", "") + "  " + productPrice.PadLeft(6);

                OrderView_Panel.Controls.Add(productInfoLabel);
            }
            catch (Exception)
            {
                MessageBox.Show("The item is not exists!!!");
            }
            BarcodeTextBox.Text = "";

        }

        private void BindingOrderDataToOrderView(Order orderData, OrderSummaryControl orderUI)
        {
            Binding bindingOrderSubTotal = new Binding("SubTotal", orderData, "SubTotal", true, DataSourceUpdateMode.Never);
            orderUI.DataBindings.Add(bindingOrderSubTotal);

            Binding bindingOrderTax = new Binding("Tax", orderData, "Tax", true, DataSourceUpdateMode.Never);
            orderUI.DataBindings.Add(bindingOrderTax);

            Binding bindingOrderDiscount = new Binding("Discount", orderData, "Discount", true, DataSourceUpdateMode.Never);
            orderUI.DataBindings.Add(bindingOrderDiscount);

            Binding bindingOrderTotal = new Binding("Total", orderData, "Total", true, DataSourceUpdateMode.Never);
            orderUI.DataBindings.Add(bindingOrderTotal);
        }
    }
}
