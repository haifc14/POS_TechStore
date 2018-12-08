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
            var ProductAvailableInSystem = productsFilteredByBrand
                                .Intersect(productsFilteredByCategory, new ProductComparer())
                                .Intersect(productsFilteredBySearch, new ProductComparer());
            var inStock = GetInstock();
            var productAvailableInStore = ProductAvailableInSystem.Join(inStock, product => product.Barcode, instock => instock.BarcodeID,
                                            (product, instock) => new { product.Barcode, instock.LocationID,instock.Quantity, product.Price, product.Discount, product.Tax, product.Name})
                                            .Where(product => product.LocationID == Helper.LocationId);
            //converting Tproduct to product object
            foreach (var item in productAvailableInStore)
            {
                var product = new Product(item.Name, item.Barcode, item.Price, (decimal)item.Discount, item.Tax, item.Quantity);
                Products.Add(product);
            }
        }

        private List<TInStock> GetInstock()
        {
            using (var contex = new DataContext(Helper.GetConnectionString()))
            {
                return contex.GetTable<TInStock>().ToList();
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
                var products = context.GetTable<TProductGroup>().ToList();
                if (filteredBrand.Count > 0)
                {
                    foreach (var item in products)
                    {
                        Console.WriteLine(products.ToString());
                    }
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
