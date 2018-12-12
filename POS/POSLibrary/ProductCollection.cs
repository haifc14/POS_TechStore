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

        
        public ProductCollection()
        {
            Products = GetTwoRandomProduct();
        }

        public ProductCollection(string customerCode)
        {
            Products = new List<Product>();

            List<int> productInfoOfRandomProductOfCustomer = GetRandomProductInoFromCertainCustomserPurchases(customerCode);
            if (productInfoOfRandomProductOfCustomer != null)
            {   // customer has bought product
                Products = GetRecommendedProductForCurrentCustomer(productInfoOfRandomProductOfCustomer);
            } 
            else
            {
                // customer has not bought any product yet
                Products = GetTwoRandomProduct();
            }
        }

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

        public Product GetRandomProduct()
        {
            using (var contex = new DataContext(Helper.GetConnectionString()))
            {
                var instock = GetInstock();
                var productGroups = contex.GetTable<TProductGroup>().ToList();
                var products = productGroups.Join(instock, product => product.Barcode, instockproduct => instockproduct.BarcodeID,
                                        (product, instockproduct) => new { product.Barcode, product.Name, product.Discount, product.Price, product.Tax, instockproduct.Quantity, instockproduct.LocationID })
                                        .Where(product => product.LocationID == Helper.LocationId).ToList();
                int productNo = rand.Next(0, products.Count);
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

        public List<int> GetRandomProductInoFromCertainCustomserPurchases(string customerCode)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
               
                var inStock = GetInstock();
                var orderItems = GetAllOrderItems();
                var orders = GetAllOrders();

                var listOfCustomerPurchasesBarcode = orders
                                                .Join(orderItems, order => order.OrderNumber, item => item.OrderNumber, (order, item) => new { order, item })
                                                .Join(inStock, itemAgain => itemAgain.item.Barcode, instock => instock.BarcodeID, (itemAgain, instock) => new { itemAgain, instock })
                                                .Where(itemAgain => itemAgain.itemAgain.order.CustomerID == customerCode && itemAgain.instock.Quantity > 0)
                                                .OrderByDescending(row => row.itemAgain.order.OrdeDate)
                                                .Select(row => new
                                                {
                                                    Barcode = row.itemAgain.item.Barcode,
                                                    Quantity = row.instock.Quantity
                                                }).ToList();

                int productNo = rand.Next(0, listOfCustomerPurchasesBarcode.Count);

                List<int> result = new List<int>();

                if (listOfCustomerPurchasesBarcode.Count > 0)
                {
                    result.Add((int)listOfCustomerPurchasesBarcode[productNo].Barcode);
                    result.Add((int)listOfCustomerPurchasesBarcode[productNo].Quantity);
                    return result;
                }
                return null;                   
            }
        }

        public Product GetProductInfoByBarcode( int barcode, int quantity)
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var productInfo = context.GetTable<TProductGroup>().Where(product => product.Barcode == barcode).ToList();
                return new Product(productInfo[0].Name, productInfo[0].Barcode, productInfo[0].Price, (decimal)productInfo[0].Discount, productInfo[0].Tax, quantity);
            }
        }

        private List<Product> GetTwoRandomProduct()
        {
            List<Product> resultList = new List<Product>();
            Product randomProductOne = GetRandomProduct();
            Product randomProductTwo = GetRandomProduct();
            resultList.Add(randomProductOne);
            resultList.Add(randomProductTwo);
            return resultList;
        }

        private List<Product> GetRecommendedProductForCurrentCustomer( List<int> productTokens) 
        {
            // it will include one latest product that customer bought + one random product from system

            List<Product> result = new List<Product>();

            Product randomProductFromFromCustomerPurchases = GetProductInfoByBarcode(productTokens[0], productTokens[1]);
            Product randomProductFromSystem = GetRandomProduct();
            result.Add(randomProductFromFromCustomerPurchases);
            result.Add(randomProductFromSystem);
            return result;
        }
    }
}
