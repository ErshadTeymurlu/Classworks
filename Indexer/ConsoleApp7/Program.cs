using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage gr = new Garage(3);
            Car cr1 = new Car("Bmw", "e39");
            Car cr2 = new Car("Bmw", "e60");
            Car cr3 = new Car("Bmw", "f30");
            gr[0] = cr1;
            gr[1] = cr2;
            gr[2] = cr3;
            Console.WriteLine(gr[0].ToString());
            Console.ReadLine();
        }
    }
}
