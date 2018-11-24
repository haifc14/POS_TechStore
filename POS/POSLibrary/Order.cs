using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary
{
    public class Order
    {
        public List<Product> ListOfItems { get; private set; } = new List<Product>();
        public decimal TotalDiscount { get; private set; }
        public decimal Total { get; private set; }
        public decimal SubTotal { get; private set; }
        public decimal Tax { get; private set; }
        public bool IsReturn { get; private set; } = false;
        public int EmployeeID;

        public Order(List<Product> listOfProducts, int employId)
        {
            ListOfItems = listOfProducts;
            EmployeeID = employId;
        }

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

        public override string ToString()
        {
            return base.ToString();
        }

        public void CompleteOrder()
        {

        }

        public void ReturnOrderComplete()
        {

        }

    }
}
