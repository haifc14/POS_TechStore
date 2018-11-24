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
            foreach (var product in new ProductCollection("","Apple", "Laptop").Products)
            {
                Console.WriteLine("a");
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to close the program!");
            Console.ReadKey();
        }
    }
}
