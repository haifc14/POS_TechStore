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
        public List<Product> Products { get; private set; }

        public ProductCollection(string keywords, string filterType = "")
        {
            var TProducts = new List<TProduct>();
            Products = new List<Product>();
            //filtering type 
            if (filterType == "brand")
            {
                TProducts = GetProductByBrands(keywords);
            }
            else if (filterType == "category")
            {
                TProducts = GetProductByCategory(keywords);
            }
            else
            {
                TProducts = GetProductsBySearch(keywords);
            }
            //converting Tproduct to product object
            foreach (var TProduct in TProducts)
            {
                var product = new Product(TProduct.Name, TProduct.Barcode, TProduct.Price, (decimal)TProduct.Discount);
                Products.Add(product);
            }
        }

        private List<TProduct> GetProductsBySearch(string keywords)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var filteredProduct = context.GetTable<TProduct>().Where(product => product.Name.Contains(keywords) || product.Barcode.ToString() == keywords);
                return filteredProduct.ToList();
            }
        }

        private List<TProduct> GetProductByBrands(string brandName)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var filteredBrand = context.GetTable<TBrand>().Where(brand => brand.Name == brandName).ToList();
                var products = context.GetTable<TProduct>();
                return products.Where(product => product.BrandID == filteredBrand[0].BrandID).ToList();
            }
        }

        private List<TProduct> GetProductByCategory(string categoryName)
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
