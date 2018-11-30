using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace POSLibrary
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string CustomerName { get; private set; }
        public int TotalPoints { get; private set; }

        public Customer(int id, string name, int points)
        {
            CustomerID = id;
            CustomerName = name;
            TotalPoints = points;
        }

        public void AddPoint(int pointToAdd)
        {
            TotalPoints += pointToAdd;
            UpdatePointsToDB();
        }

        public void RedeemPoint(int pointToRedeem)
        {
            if (TotalPoints < pointToRedeem)
            {
                throw new ArgumentException("Not enough points in the account");
            }

            TotalPoints -= pointToRedeem;
            UpdatePointsToDB();
        }

        public int GetToTalPoints()
        {
            return TotalPoints;
        }

        private void UpdatePointsToDB()
        {
            // update points to DB
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var TCustomer = context.GetTable<TCustomer>();

                var currentCustomerInfo = TCustomer.Where(customer => customer.CustomerID == this.CustomerID).ToList();

                currentCustomerInfo[0].TotalPoints = this.TotalPoints;

                context.SubmitChanges();
            }
             
        }
    }
}
