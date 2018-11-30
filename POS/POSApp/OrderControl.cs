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

                // Check if ItemBarcode was scanned or customer barcode was scanned

                bool canConvertToNumber = int.TryParse(barcodeFromInput, out int itemBarcode);

                if(canConvertToNumber) // is item barcode since item barcode is always a int number
                {
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
                    OrderItemControl ItemControl = new OrderItemControl();

                    ItemControl.ItemBarcode = scannedItem.Barcode.ToString();
                    ItemControl.ItemName = scannedItem.Name;
                    ItemControl.ItemPrice = scannedItem.Price.ToString();
                    OrderView_Panel.Controls.Add(ItemControl);
                }
                else
                {
                    // is Customer code since customer barcode contain 'C' letter befor number
                    // so that it cannot be parsed to int number
                    Customer customer = new Customer(barcodeFromInput);

                    string customerName = customer.GetCustomerName();
                    int customerPoints = customer.GetCustomerPoints();

                    CustomerNameLabel.Text = customerName;
                    CustomerPointsLabel.Text = customerPoints.ToString();

                }
                
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
