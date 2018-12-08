﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace POSLibrary
{
    public static class Helper
    {
        internal const decimal PointsWorthTo1Dollar = 1000;
        internal const decimal PointsGainFactorFrom1Dollar = 1;
        internal const int LocationId = 4;

        internal static string GetConnectionString()
        {
            System.Data.SqlClient.SqlConnectionStringBuilder builder =
                           new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = "199.103.60.77";
            builder["Initial Catalog"] = "retailmgmt";
            builder["User Id"] = "retailmgmt";
            builder["Password"] = "dgQDR9q8THTgalP";
            return builder.ConnectionString;
        }

        public static List<string> GetBrands()
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var filteredProduct = context.GetTable<TBrand>().Select(brand => brand.Name);
                return filteredProduct.ToList();
            }
        }

        public static List<string> GetCategories()
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                var filteredProduct = context.GetTable<TCategory>().Select(category => category.Name);
                return filteredProduct.ToList();
            }
        }
    }
}
