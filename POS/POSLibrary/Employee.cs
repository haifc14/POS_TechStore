using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POSLibrary
{
    public class Employee
    {
        public int UserName { get; private set; }
        public int Password { get; private set; }
        public List<TEmployee> MatchedUserCredentials { get; private set; } 

        public Employee(int username, int password)
        {
            UserName = username;
            Password = password;
            MatchedUserCredentials = new List<TEmployee>();
        }

        public bool IsAuthenticated()
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                IEnumerable<TEmployee> matchedUserCredential = context.GetTable<TEmployee>().Where(employee => employee.Username == UserName && employee.Pwd == Password);
                MatchedUserCredentials = matchedUserCredential.ToList();
            }

            if (MatchedUserCredentials.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
