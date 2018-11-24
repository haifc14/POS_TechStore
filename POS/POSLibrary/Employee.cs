using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POSLibrary
{
    public class Employee
    {
        public int UserName { get; private set; }
        public int Password { get; private set; }
        public List<TUserLogin> MatchedUserCredentials { get; private set; } 

        public Employee(int username, int password)
        {
            UserName = username;
            Password = password;
            MatchedUserCredentials = new List<TUserLogin>();
        }

        public bool IsAuthenticated()
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                IEnumerable<TUserLogin> matchedUserCredential = context.GetTable<TUserLogin>().Where(employee => employee.UserName.Equals(UserName) && employee.Password.Equals(Password));
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
