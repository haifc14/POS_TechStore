using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Linq;

namespace POSLibrary
{
    public class ProductCollection
    {
        public List<Product> Products { get; private set; }


        public ProductCollection(string keywords, string brandName = "", string categoryName = "")
        {
            Products = new List<Product>();
            var productsFilteredByBrand = GetProductByBrands(brandName);
            var productsFilteredByCategory = GetProductByCategory(categoryName);
            var productsFilteredBySearch = GetProductsBySearch(keywords);
            var TProducts = productsFilteredByBrand
                                .Intersect(productsFilteredByCategory, new ProductComparer())
                                .Intersect(productsFilteredBySearch, new ProductComparer());
            //converting Tproduct to product object
            foreach (var TProduct in TProducts)
            {
                var product = new Product(TProduct.Name, TProduct.Barcode, TProduct.Price, (decimal)TProduct.Discount);
                Products.Add(product);
            }
        }

        private List<TProductGroup> GetProductsBySearch(string keywords)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var filteredProduct = context.GetTable<TProductGroup>().Where(product => product.Name.Contains(keywords) || product.Barcode.ToString() == keywords);
                return filteredProduct.ToList();
            }
        }

        private List<TProductGroup> GetProductByBrands(string brandName)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var filteredBrand = context.GetTable<TBrand>().Where(brand => brand.Name == brandName).ToList();
                var products = context.GetTable<TProductGroup>();
                if (filteredBrand.Count > 0)
                {
                    return products.Where(product => product.BrandID == filteredBrand[0].BrandID).ToList();
                }
                return products.ToList();
            }
        }

        private List<TProductGroup> GetProductByCategory(string categoryName)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var filteredCategory = context.GetTable<TCategory>().Where(category => category.Name == categoryName).ToList();
                var products = context.GetTable<TProductGroup>();
                if (filteredCategory.Count() > 0)
                {
                    return products.Where(product => product.CategoryID == filteredCategory[0].CategoryID).ToList();
                }
                return products.ToList();
            }
        }
    }
}
