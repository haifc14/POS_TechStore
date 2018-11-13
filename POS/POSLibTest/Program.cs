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
            ProductCollection collection = new ProductCollection("5", "");
            foreach (var product in collection.Products)
            {
                Console.WriteLine(product.ToString());
            }

            Console.ReadKey();
        }
    }
}
