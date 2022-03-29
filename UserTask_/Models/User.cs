using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                bool upperCase = false;
                bool lowerCase = false;
                bool isDigit = false;
                foreach (char letter in value)
                {
                    if (!upperCase)
                    {
                        if (Char.IsUpper(letter)) upperCase = true;
                    }
                    if (!lowerCase)
                    {
                        if (Char.IsLower(letter)) lowerCase = true;
                    }
                    if (!isDigit)
                    {
                        if (Char.IsDigit(letter)) isDigit = true;
                    }
                }
                if (upperCase == true && lowerCase == true && isDigit == true) _password = value;  
            }
        }
    }
}
