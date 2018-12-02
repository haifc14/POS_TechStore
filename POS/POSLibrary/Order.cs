using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSLibrary
{
    public class Order : INotifyPropertyChanged
    {
        #region Properties
        public List<Product> ListOfItems { get; set; } = new List<Product>();
        public decimal TotalDiscount { get; set; } = 0;
        public const decimal PointsWorthTo1Dollar = 1000; 
        public const decimal PointsGainFactorFrom1Dollar = 1;

        private decimal _total;

        public decimal Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }

        private decimal _subTotal;

        public decimal SubTotal
        {
            get { return _subTotal; }
            set
            {
                _subTotal = value;
                OnPropertyChanged("SubTotal");
            }
        }

        private decimal _tax;

        public decimal Tax
        {
            get { return _tax; }
            set
            {
                _tax = value;
                OnPropertyChanged("Tax");
            }
        }

        private decimal _discount;

        public decimal Discount
        {
            get { return _discount; }
            set
            {
                _discount = value;
                OnPropertyChanged("Discount");
            }
        }

        private decimal _employeeDiscount = 0;

        public decimal EmployeeDiscount
        {
            get { return _employeeDiscount; }
            set { _employeeDiscount = value; }
        }
        public Customer Customer { get; set; }
        public decimal TotalPaidByCash { get; private set; }
        public decimal TotalPaidByCard { get; private set; }
        public int TotalRedeemPoints { get; private set; }
        public decimal BalanceDue { get; private set; }

        public bool IsReturn { get; set; } = false;
        public int EmployeeID { get; set; } = 0;

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Constructor
        public Order(bool isReturn, Customer customer)
        {
            IsReturn = isReturn;
            this.Customer = customer;
        }

        public Order(Customer customer)
        {
            this.Customer = customer;
        }

        #endregion

        #region Methods
        public void PayByCash(decimal moneyPaid)
        {
            this.TotalPaidByCash = moneyPaid;
        }

        public void PayByCard(decimal moneyPaid)
        {
            this.TotalPaidByCard = moneyPaid;
        }

        public void ReedemPoints(int points)
        {
            if (points <= this.Customer.GetPoints())
            {
                this.TotalRedeemPoints = points;
            }
            else
            {
                throw new Exception("Not enough points available to redeem!");
            }
        }

        public void EarnPoints()
        {
            UpdateOrderInfo();
            this.Customer.EarnPoints((int) this.Total);
        }

        public void AddItem(Product productToAdd)
        {
            ListOfItems.Add(productToAdd);
            UpdateOrderInfo();         
        }

        public void AddEmployeeDiscount(decimal discount)
        {
            EmployeeDiscount += discount;
            UpdateOrderInfo();
        }

        public void RemoveItem(Product productToRemove)
        {
            ListOfItems.Remove(productToRemove);
            UpdateOrderInfo();          
        }

        public void EditDiscount(decimal newTotalDiscount)
        {
            TotalDiscount += newTotalDiscount;
        }
      
        public override string ToString()
        {
            return base.ToString();
        }
        
        private void UpdateOrderInfo()
        {
            ResetOrder();
            foreach (var product in ListOfItems)
            {
                SubTotal += product.Price;
                Tax += product.Tax;
                Discount += product.Discount;              
            }
            Total = (SubTotal + Tax) - Discount - EmployeeDiscount;
        }

        public void UpdateOrderStatus()
        {
            if (!IsReturn) return;

            Total = -Total;       
        }

        private void ResetOrder()
        {
            Total = 0;
            SubTotal = 0;
            Tax = 0;
            Discount = 0;
        }

        protected virtual void OnPropertyChanged(string newName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(newName));
        }

        #endregion


    }
}
