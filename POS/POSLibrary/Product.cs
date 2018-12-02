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
         
        public Product(string name, int barcode, decimal price, decimal discount, decimal tax)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
            Discount = discount;
            Tax = tax;
        }

        public Product(int barcode)
        {
            var TProduct  = GetProducts(barcode);
            Name = TProduct.Name;
            Barcode = TProduct.Barcode;
            Price = TProduct.Price;
            Discount = (decimal)TProduct.Discount;
            Tax = TProduct.Tax;
        }

        public override string ToString()
        {
            return Name + " " + Barcode + " " + Price + " " + Discount;
        }

        private static TProductGroup GetProducts(int barcode)
        {
            var context = new DataContext(Helper.GetConnectionString());
            var products = context.GetTable<TProductGroup>();
            var filteredProduct = products.Where(product => product.Barcode == barcode).ToList();
            context.Dispose();
            return filteredProduct[0];
        }       
    }
}
