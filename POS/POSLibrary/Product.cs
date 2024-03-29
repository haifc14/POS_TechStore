﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace POSLibrary
{
    public class Product
    {
        public string Name { get; private set; }
        public int Barcode { get; private set; }
        public decimal Price { get; private set; }
        public decimal Discount { get; private set; }
        public decimal Tax { get; private set; }
        public int Quantity { get; private set; }
         
        public Product(string name, int barcode, decimal price, decimal discount, decimal tax, int quantity)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
            Discount = discount;
            Tax = tax;
            Quantity = quantity;
        }

        public void RetrunProduct()
        {
            Price = -Price;
            Discount = -Discount;
            Tax = -Tax;
        }

        public Product(int barcode, bool checkForQuantity = false)
        {
            GetProductInfo(barcode, checkForQuantity);
        }

        public override string ToString()
        {
            return Name + "-\t" + Barcode + "-\t" + Price + "-\t" + Discount;
        }

        //get product info by barcode
        //checkForQunatity if its scan, do not check if its returnOrder
        private void GetProductInfo(int barcode, bool checkForQuantity = false)
        {
            using (var contex = new DataContext(Helper.GetConnectionString()))
            {
                var products = contex.GetTable<TProductGroup>();
                var inStocks = contex.GetTable<TInStock>();
                
                if (checkForQuantity)
                {
                    var filteredProductInStore = products.Join(inStocks, product => product.Barcode, instock => instock.BarcodeID,
                                                (product, instock) => new { product.Barcode, product.Name, product.Price, product.Discount, product.Tax, instock.Quantity, instock.LocationID })
                                                .Where(filtered => filtered.LocationID == Helper.LocationId);
                    var productAvailableInStore = filteredProductInStore.Where(filteredProduct => (filteredProduct.Quantity > 0) && filteredProduct.Barcode == barcode).ToList();
                    if (productAvailableInStore.Count > 0)
                    {
                        this.Name = productAvailableInStore[0].Name;
                        this.Price = productAvailableInStore[0].Price;
                        this.Tax = productAvailableInStore[0].Tax;
                        this.Barcode = productAvailableInStore[0].Barcode;
                        this.Discount = (decimal)productAvailableInStore[0].Discount;
                        this.Quantity = productAvailableInStore[0].Quantity;
                    }
                    else
                    {
                        throw new Exception("Product not available in store!");
                    }
                }
                else
                {
                    var filteredProductInStore = products.Join(inStocks, product => product.Barcode, instock => instock.BarcodeID,
                                                (product, instock) => new { product.Barcode, product.Name, product.Price, product.Discount, product.Tax, instock.Quantity, instock.LocationID })
                                                .Where(filtered => filtered.LocationID == Helper.LocationId);
                    var productAvailableInStore = filteredProductInStore.Where(filteredProduct => filteredProduct.Barcode == barcode).ToList();
                    if (productAvailableInStore.Count > 0)
                    {
                        this.Name = productAvailableInStore[0].Name;
                        this.Price = productAvailableInStore[0].Price;
                        this.Tax = productAvailableInStore[0].Tax;
                        this.Barcode = productAvailableInStore[0].Barcode;
                        this.Discount = (decimal)productAvailableInStore[0].Discount;
                        this.Quantity = productAvailableInStore[0].Quantity;
                    }
                    else
                    {
                        throw new Exception("Invalid barcode!!!");
                    }
                } 
            }
        }       
    }
}
