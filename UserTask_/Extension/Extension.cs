using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask_.Extension
{
    static class Extension
    {
        public static bool IsUp(this string password)
        {
            for(int i = 0; i < password.Length; i++) if(password[i]>=65 && password[i]<=90) return true;
            return false;
        }
        public static bool IsLow(this string password)
        {
            for (int i = 0; i < password.Length; i++) if (password[i] >= 97 && password[i] <= 122) return true;
            return false;
        }
        public static bool IsDigit(this string password)
        {
            for (int i = 0; i < password.Length; i++) if (password[i] >= 48 && password[i] <= 57) return true;
            return false;
        }
    }
}
