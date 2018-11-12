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
       
        public static string GetConnectionString(string serverName)
        {
            System.Data.SqlClient.SqlConnectionStringBuilder builder =
                           new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = serverName;
            builder["Initial Catalog"] = "retailmgmt";
            builder["User Id"] = "retailmgmt";
            builder["Password"] = "dgQDR9q8THTgalP";
            return builder.ConnectionString;
        }
    }
}
