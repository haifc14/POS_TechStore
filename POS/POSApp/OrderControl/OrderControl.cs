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
        private Order _currentOrder;

        public Action<int> ScanProduct;

        public Order CurrentOrder
        {
            get
            {
                return this._currentOrder;
            }
            set
            {
                this._currentOrder = value;
            }
        }
        public OrderSummaryControl OrderSummaryView { get; private set; }

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

        public string OrderType
        {
            get { return OrderType_Label.Text; }
            set { OrderType_Label.Text = value; }
        }

        public OrderControl()
        {
            InitializeComponent();
            CurrentOrder = new Order(new Customer());
            OrderSummaryView = new OrderSummaryControl();
            // Binding data of Temporary Order To OrderSummaryControl                 
            BindingOrderDataToOrderView(CurrentOrder, OrderSummaryView);
            ScanProduct += ScanItem;
        }

        private void ScanItem(int barcode)
        {
            try
            {
                // Get Scanned Product info 
                Product scannedItem = new Product(barcode);
                if (CurrentOrder.IsReturn)
                {
                    scannedItem.RetrunProduct();
                }
                // display the scanned item on Left Product Panel            
                OrderItemControl ItemControl = new OrderItemControl(scannedItem);
                ItemControl.RemoveItemEvent += RemoveItem();
                OrderView_Panel.Controls.Add(ItemControl);

                // Adding scanned item to a order                 
                CurrentOrder.AddItem(scannedItem);

                // Display Order Info to form
                // OrderSummaryFlowPanel.Controls.Clear();
                OrderSummaryFlowPanel.Controls.Add(OrderSummaryView);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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

                if(canConvertToNumber == true) // is item barcode since item barcode is always a int number
                {
                    ScanProduct(itemBarcode);
                }
                else
                {
                    // is Customer code since customer barcode contain 'C' letter befor number
                    // so that it cannot be parsed to int number
                    Customer customer = new Customer(barcodeFromInput);

                    CurrentOrder.Customer = customer;

                    string customerName = customer.GetName();
                    int customerPoints = customer.GetPoints();

                    // display customer name and points to the view
                    CustomerNameLabel.Text = customerName;
                    CustomerPointsLabel.Text = customerPoints.ToString();
                }

                BarcodeTextBox.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                BarcodeTextBox.Text = "";
            }
            
        }

        private void BindingOrderDataToOrderView(Order orderData, OrderSummaryControl orderUI)
        {

            Binding bindingOrderSubTotal = new Binding("SubTotal", orderData, "SubTotal", true, DataSourceUpdateMode.OnPropertyChanged);
            orderUI.DataBindings.Add(bindingOrderSubTotal);

            Binding bindingOrderTax = new Binding("Tax", orderData, "Tax", true, DataSourceUpdateMode.OnPropertyChanged);
            orderUI.DataBindings.Add(bindingOrderTax);

            Binding bindingOrderDiscount = new Binding("Discount", orderData, "Discount", true, DataSourceUpdateMode.OnPropertyChanged);
            orderUI.DataBindings.Add(bindingOrderDiscount);

            Binding bindingOrderTotal = new Binding("Total", orderData, "Total", true, DataSourceUpdateMode.OnPropertyChanged);
            orderUI.DataBindings.Add(bindingOrderTotal);
        }

        private Action<Product, OrderItemControl> RemoveItem()
        {           
            return (product, orderItemControl) =>
            {
                CurrentOrder.RemoveItem(product);
                this.OrderView_Panel.Controls.Remove(orderItemControl);
            };         
        }

        private void OrderControl_Load(object sender, EventArgs e)
        {

        }
    }
}
