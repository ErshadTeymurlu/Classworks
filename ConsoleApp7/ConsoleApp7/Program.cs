using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7.Models;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon wp = new Weapon(100, 42, 10,'S');
            Console.WriteLine("Discharge second: "+wp.Fire());
            Console.WriteLine("Current Bullet Info: "+wp.GetBulletInfo());
            wp.Reload();
            Console.WriteLine("Current Bullet Info: " + wp.GetBulletInfo());
            wp.Shot();
            wp.Shot();
            wp.Shot();
            wp.Shot();
            wp.Shot();
            Console.WriteLine("SINGLE MODE Current Bullet Info: " + wp.GetBulletInfo());
            wp.ChangeFireMode(); //auto
            wp.Shot();
            wp.Shot();
            wp.Shot();
            wp.Shot();
            wp.Shot();
            Console.WriteLine("AUTO MODE Current Bullet Info: " + wp.GetBulletInfo());
            wp.ChangeFireMode(); //single
            wp.Shot();
            wp.Shot();
            wp.Shot();
            wp.Shot();
            Console.WriteLine("SINGLE MODE Current Bullet Info: " + wp.GetBulletInfo());
            Console.ReadLine();
        }
    }
}
