using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

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

        public List<TProduct> GetProductByBrands(string brandName)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var filteredBrand = context.GetTable<TBrand>().Where(brand => brand.Name == brandName).ToList();
                var products = context.GetTable<TProduct>();
                return products.Where(product => product.BrandID == filteredBrand[0].BrandID).ToList();
            }
        }

        public List<TProduct> GetProductByCategory(string categoryName)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var filteredCategory = context.GetTable<TCategory>().Where(category => category.Name == categoryName).ToList();
                var products = context.GetTable<TProduct>();
                return products.Where(product => product.CategoryID == filteredCategory[0].CategoryID).ToList();
            }
        }
    }
}
