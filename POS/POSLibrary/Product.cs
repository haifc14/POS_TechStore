using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary
{
    public class Product
    {
        public string Name { get; private set; }
        public int Barcode { get; private set; }
        public decimal Price { get; private set; }
        public decimal Discount { get; private set; }

        public Product(string name, int barCode, decimal price, decimal discount)
        {
            Name = name;
            Barcode = barCode;
            Price = price;
            Discount = discount;
        }

        public override string ToString()
        {
            return Name + " " + Barcode + " " + Price + " " + Discount;
        }

    }
}
