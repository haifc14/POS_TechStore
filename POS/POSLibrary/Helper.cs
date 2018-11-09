using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Linq;

namespace POSLibrary
{
    public static class Helper
    {
        public static void ConnectPOSDB()
        {
            var context = new DataContext(GetConnectionString("199.103.60.77"));
            var products = context.GetTable<PProduct>();
            Console.WriteLine(products.Count());
            Console.ReadKey();
        }

        static string GetConnectionString(string serverName)
        {
            System.Data.SqlClient.SqlConnectionStringBuilder builder =
                           new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = serverName;
            builder["Initial Catalog"] = "bpatel405";
            builder["User Id"] = "bpatel405";
            builder["Password"] = "6657975543222680";
            return builder.ConnectionString;
        }
    }
}
