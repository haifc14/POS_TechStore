using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace POSLibrary
{
    public static class Helper
    {
        public const decimal PointsWorthTo1Dollar = 1000;
        public const decimal PointsGainFactorFrom1Dollar = 1;
        internal const int LocationId = 4;

        public static string FILE_PATH_DETAIL_REPORT = @"../../../ReportDataFiles/dayenddetail.txt";
        public static string FILE_PATH_DAYEND_REPORT = @"../../../ReportDataFiles/dayendreport.txt";

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
            using (var context = new DataContext(GetConnectionString()))
            {
                var filteredProduct = context.GetTable<TCategory>().Select(category => category.Name);
                return filteredProduct.ToList();
            }
        }

        public static List<TOrder> GetAllOrdersForDayEnd(DateTime currentDay)
        {            
            var day = currentDay.Day;

            using (var context = new DataContext(GetConnectionString()))
            {
                var listOfOrderWithinADay = context.GetTable<TOrder>().Where(order => order.OrdeDate.Day.Equals(day)).ToList();
                return listOfOrderWithinADay;
            }
        }

        public static string GetEmployeeNameFromOrderReport(int employeeId)
        {
            using (var context = new DataContext(GetConnectionString()))
            {
                var employees = context.GetTable<TEmployee>().Where(employee => employee.EmployeeId == employeeId).ToList();

                if (employees.Count > 0)
                {
                    var employeeFullNameFound = employees[0].FirstName + ' ' + employees[0].LastName;
                    return employeeFullNameFound;
                }

                return "no name";
            }
        }

        public static decimal GetTotalIncomeOfCurrentDay(DateTime currentDate)
        {
            //var currentDay = currentDate.Day;
            var currentDay = DateTime.Parse("2018 - 12 - 09 00:00:03.9508688").Day;

            using (var context = new DataContext(GetConnectionString()))
            {
                var totalIncome = context.GetTable<TOrder>().Where(order => order.OrdeDate.Day == currentDay).Select(order => order.TotalPrice).Sum();

                return totalIncome;                                                               
            }
        }

        public static decimal GetTotalIncomeByCardOfCurrentDay(DateTime currentDate)
        {
            //var currentDay = currentDate.Day;
            var currentDay = DateTime.Parse("2018 - 12 - 09 00:00:03.9508688").Day;

            using (var context = new DataContext(GetConnectionString()))
            {
                var totalIncomeByCard = context.GetTable<TOrder>().Where(order => order.OrdeDate.Day == currentDay).Select(order => order.CardPayment).Sum();

                return totalIncomeByCard;
            }
        }

        public static decimal GetTotalIncomeByCashOfCurrentDay(DateTime currentDate)
        {
            //var currentDay = currentDate.Day;
            var currentDay = DateTime.Parse("2018 - 12 - 09 00:00:03.9508688").Day;

            using (var context = new DataContext(GetConnectionString()))
            {
                var totalIncomeByCash = context.GetTable<TOrder>().Where(order => order.OrdeDate.Day == currentDay).Select(order => order.CashPayment).Sum();

                return totalIncomeByCash;
            }
        }

        public static int GetTotalOrdersOfCurrentDay(DateTime currentDate)
        {
            //var currentDay = currentDate.Day;
            var currentDay = DateTime.Parse("2018 - 12 - 09 00:00:03.9508688").Day;

            using (var context = new DataContext(GetConnectionString()))
            {
                var totalOrdersOfCurrentDay = context.GetTable<TOrder>().Where(order => order.OrdeDate.Day == currentDay).Count();

                return totalOrdersOfCurrentDay;
            }
        }

        public static int GetTotalRedeemPointsOfCurrentDay(DateTime currentDate)
        {
            //var currentDay = currentDate.Day;
            var currentDay = DateTime.Parse("2018 - 12 - 09 00:00:03.9508688").Day;

            using (var context = new DataContext(GetConnectionString()))
            {
                var totalRedeemPoints = context.GetTable<TOrder>().Where(order => order.OrdeDate.Day == currentDay).Select(order => order.PoitRedeem).Sum();
                return (int)totalRedeemPoints;
            }
        }

        public static int GetTotalItemsOfCurrentDay(DateTime currentDate)
        {
            //var currentDay = currentDate.Day;
            var currentDay = DateTime.Parse("2018 - 12 - 09 00:00:03.9508688").Day;

            using (var context = new DataContext(GetConnectionString()))
            {
                var totalItems = from order in context.GetTable<TOrder>()
                                 join orderItems in context.GetTable<TOrderItem>() on order.OrderNumber equals orderItems.OrderNumber
                                 where order.OrdeDate.Day == currentDay
                                 select new { OrderNumber = order.OrderNumber };

                return totalItems.Count();              
            }
        }
    }
}
