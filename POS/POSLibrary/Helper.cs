using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace POSLibrary
{
    public static class Helper
    {
        public static string DB_CONNECTION_STRING = ConfigurationManager.ConnectionStrings["bpatel405Entities"].ConnectionString;

        public static void ConnectPOSDB()
        {
            
        }
    }
}
