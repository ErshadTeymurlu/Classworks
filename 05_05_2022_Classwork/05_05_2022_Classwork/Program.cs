using System;
using _05_05_2022_Classwork.Model;

namespace _05_05_2022_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Word wd = new Word("5", "Text1");
            Console.WriteLine(PrintFile<Word>.Print(wd));
            Console.ReadLine();
        }
    }
}
