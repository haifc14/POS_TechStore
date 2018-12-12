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
        internal string CustomerName;
        public string CustomerId;
        internal int CustomerPoints;

        public Customer()
        {
            CustomerId = "-1";
            CustomerName = "";
            CustomerPoints = 0;
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
            if (filteredCustomers.Count > 0)
            {
                return filteredCustomers[0];
            }        
            else
            {
                throw new Exception("Invalid data provided for customer!");
            }

        }

        public string GetName()
        {
            return CustomerName;
        }

        public int GetPoints()
        {
            return CustomerPoints;
        }

        public void ReedemPoints(int points)
        {
            this.CustomerPoints -= points;
        }
    }
}
