using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary
{
    public class Customer
    {
        private string CustomerName;
        private string CustomerId;
        private int CustomerPoints;

        public Customer()
        {

        }

        public Customer(string customerId)
        {
            CustomerId = customerId;
            var TCustomer = GetCustomerInfoFromDB();
            CustomerName = TCustomer.Name;
            CustomerPoints = (int)TCustomer.TotalPoints;
        }

        private TCustomer GetCustomerInfoFromDB()
        {
            var context = new DataContext(Helper.GetConnectionString());
            var customers = context.GetTable<TCustomer>();
            var filteredCustomers = customers.Where(customer => customer.CustomerId == CustomerId).ToList();
            var currentCustomer = filteredCustomers[0];
            return currentCustomer;
        }

        public string GetName()
        {
            return CustomerName;
        }

        public int GetPoints()
        {
            return CustomerPoints;
        }

        public void EarnPoints(int points)
        {
            this.CustomerPoints = points;
        }


    }
}
