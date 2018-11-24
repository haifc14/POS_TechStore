using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary
{
    public class Order
    {
        #region Properties
        public List<Product> ListOfItems { get; private set; } = new List<Product>();
        public decimal TotalDiscount { get; private set; } = 0;
        public decimal Total { get; private set; } = 0;
        public decimal SubTotal { get; private set; } = 0;
        public decimal Tax { get; private set; }
        public decimal Discount { get; private set; } = 0;
        public bool IsReturn { get; private set; } = false;
        public int EmployeeID { get; }
        #endregion

        #region Constructor
        public Order(List<Product> listOfProducts, int employId, bool isReturn)
        {
            ListOfItems = listOfProducts;
            EmployeeID = employId;           
            CalculateSubTotal();
            CalculateTax();
            CalculateDiscount();
            CalculateTotal();
            IsReturn = isReturn;
            UpdateOrderStatus();
        }
        #endregion

        #region Methods
        public void AddItem(Product productToAdd)
        {
            ListOfItems.Add(productToAdd);
        }

        public void RemoveItem(Product productToRemove)
        {
            ListOfItems.Remove(productToRemove);
        }

        public void EditDiscount(decimal newTotalDiscount)
        {
            TotalDiscount += newTotalDiscount;
        }

        public void UpdateTotal(decimal newTotal)
        {
            Total += newTotal;
        }

        public void UpdateSubTotal(decimal newSubTotal)
        {
            SubTotal += newSubTotal;
        }

        private void CalculateSubTotal()
        {
            foreach (var item in ListOfItems)
            {
                SubTotal += item.Price;
            }
        }

        private void CalculateTax()
        {
            foreach (var item in ListOfItems)
            {
                Tax += item.Tax;
            }
        }

        private void CalculateDiscount()
        {
            foreach (var item in ListOfItems)
            {
                Discount += item.Discount;
            }
        }

        private void CalculateTotal()
        {
            Total = (SubTotal + Tax) - Discount;
        }

        public override string ToString()
        {
            return base.ToString();
        }       

        public void UpdateOrderStatus()
        {
            if (!IsReturn) return;

            Total = -Total;       
        }

        #endregion


    }
}
