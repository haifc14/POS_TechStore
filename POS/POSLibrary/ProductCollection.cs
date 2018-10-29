using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSLibrary
{
    public class ProductCollection
    {
        public string Name { get; set; }
        public List<Product> products;

        public List<Product> GetProducts(string keyWords, string filterType)
        {
            throw new NotImplementedException();
        }

        private List<Product> GetProductsBySearch()
        {
            throw new NotImplementedException();
        }

        private List<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }

        private List<Product> GetProductsByBrands()
        {
            throw new NotImplementedException();
        }
    }
}
