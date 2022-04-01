using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTask_.Models;

namespace UserTask_
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            User us1 = new User("user_name1", "sS2dsa");
            Console.WriteLine($"Username - {us1.UserName}\nPassword - {us1.Password}");
            Console.ReadLine();
        }
    }
}
