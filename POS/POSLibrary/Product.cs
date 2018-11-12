using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace POSLibrary
{
    public class Product
    {
        public string Name { get; private set; }
        public int Barcode { get; private set; }
        public decimal Price { get; private set; }
        public decimal Discount { get; private set; }
         

        public Product(string barcode)
        {
            int validBarcode = GetValidBarcode(barcode);
            var TProduct  = GetProducts(validBarcode);
            Name = TProduct.Name;
            Barcode = TProduct.Barcode;
            Price = TProduct.Price;
            Discount = (decimal)TProduct.Discount;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        private static TProduct GetProducts(int barcode)
        {
            var context = new DataContext(Helper.GetConnectionString("199.103.60.77"));
            var products = context.GetTable<TProduct>();
            var filteredProduct = products.Where(product => product.Barcode == barcode).ToList();
            context.Dispose();
            return filteredProduct[0];
        }

        private int GetValidBarcode(string barcode)
        {
            bool isValidBarcode = int.TryParse(barcode, out int validBarcode);

            if (!isValidBarcode)
            {
                throw new ArgumentException("Invalid Barcode supplied");
            }

            return validBarcode;
        }

    }
}
