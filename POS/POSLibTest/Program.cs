using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSLibrary;

namespace POSLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection pc = new ProductCollection();
            var products = pc.GetProductByBrands("Apple");
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadKey();
        }
    }
}
