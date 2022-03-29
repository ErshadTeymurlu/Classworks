using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_03_2002_Classwork_Library
{
    public class User
    {
        private string _name;
        private string _email;
        private string _password;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length <= 100) _name = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length <= 100 && value.Contains('@')) _email = value;
            }
        }
        protected string Password
        {
            get { return _password; }
            set
            {
                if (value.Length >= 8) _password = value;
            }
        }

    }
}
