using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserTask_.Extension;

namespace UserTask_.Models
{
    internal class User
    {
        private string _username;
        private string _password;
        private Regex rgx;
        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public string UserName
        {
            get { return _username; }
            set
            {
                rgx = new Regex(@"^\w{6,25}[._]?$");
                if (rgx.IsMatch(value)) _username = value;
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.IsUp() == true && value.IsLow() == true && value.IsDigit() == true) _password = value;
            }
        }
    }
}
