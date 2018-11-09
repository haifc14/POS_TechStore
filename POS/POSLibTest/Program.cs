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
            int barcode = 2;
           var productFound =  Helper.GetProducts(barcode);

            Console.WriteLine(productFound.Name);
            Console.WriteLine(productFound.Quantity);

            Console.ReadKey();
        }
    }
}
