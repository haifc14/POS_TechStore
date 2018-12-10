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
        private Random rand = new Random();

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

        private Product GetRandomProduct()
        {
            using (var contex = new DataContext(Helper.GetConnectionString()))
            {
                var instock = GetInstock();
                var products = contex.GetTable<TProductGroup>().Join(instock, product => product.Barcode, instockproduct => instockproduct.BarcodeID,
                                        (product, instockproduct) => new { product.Barcode, product.Name, product.Discount, product.Price, product.Tax, instockproduct.Quantity, instockproduct.LocationID })
                                        .Where(product => product.LocationID == Helper.LocationId).ToList();
                int productNo = rand.Next(0, Products.Count);
                var filteredProduct = products[productNo];
                var recommendedProduct = new Product(filteredProduct.Name, filteredProduct.Barcode, filteredProduct.Price, (decimal)filteredProduct.Discount, filteredProduct.Tax, filteredProduct.Quantity);
                return recommendedProduct;
            }
        }

        private List<TOrderItem> GetAllOrderItems()
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var orderItems = context.GetTable<TOrderItem>().ToList();
                return orderItems;
            }
        }

        private List<TOrder> GetAllOrders()
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var orders = context.GetTable<TOrder>().ToList();
                return orders;
            }
        }

        public int GetBarcodeOfLatestPurchasedForCertainCustomser(string customerCode)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var inStock = GetInstock();
                var orderItems = GetAllOrderItems();
                var orders = GetAllOrders();

                var barcodeOfLatestProductOfCuurentCustomer = orders
                                                .Join(orderItems, order => order.OrderNumber, item => item.OrderNumber, (order, item) => new { order, item })
                                                .Join(inStock, itemAgain => itemAgain.item.Barcode, instock => instock.BarcodeID, (itemAgain, instock) => new { itemAgain, instock })
                                                .Where(itemAgain => itemAgain.itemAgain.order.CustomerID == customerCode && itemAgain.instock.Quantity > 0)
                                                .OrderByDescending(row => row.itemAgain.order.OrdeDate).Take(1)
                                                .Select(row => new
                                                {
                                                    Barcode = row.itemAgain.item.Barcode                                                  
                                                }).ToList();

                return (int)barcodeOfLatestProductOfCuurentCustomer[0].Barcode;
            }
        }

        public TProductGroup GetProductInfoByBarcode(int barcode)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var productInfo = context.GetTable<TProductGroup>().Where(product => product.Barcode == barcode).ToList();
                return productInfo[0];
            }
        }
    }
}
