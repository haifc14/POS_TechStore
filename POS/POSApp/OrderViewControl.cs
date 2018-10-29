using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSLibrary;

namespace POSApp
{
    public class OrderViewControl
    {
        public Order CurrentOrder { get; private set; }

        /// <summary>
        /// All the methods below are events hanlder which will affect the current order
        /// </summary>
        public void ScanItem()
        {
            
        }

        public void PayByCard()
        {
            
        }

        public void PayByCash()
        {
            
        }

        public void RedeemPoint()
        {

        }

        public void ScanPointCard()
        {

        }

        public void Discount()
        {

        }

        public void Return()
        {

        }

        public void PrintReciept()
        {

        }

        public void ItemVoid()
        {

        }

        public void AbortOrder()
        {

        }

    }
}
