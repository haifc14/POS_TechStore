﻿using System;
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
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public List<TUserLogin> MatchedUserCredentials { get; private set; } 

        public Employee(string username, string password)
        {
            UserName = username;
            Password = password;
            MatchedUserCredentials = new List<TUserLogin>();
        }

        public int GetEmployeeID()
        {
            using (var context = new DataContext(Helper.GetConnectionString()))
            {
                IEnumerable<TUserLogin> matchedUserCredential = context.GetTable<TUserLogin>().Where(employee => employee.UserName.Equals(UserName) && employee.Password.Equals(Password));
                MatchedUserCredentials = matchedUserCredential.ToList();

                return (int)MatchedUserCredentials[0].EmployeeId;
            }     
        }
    }
}
