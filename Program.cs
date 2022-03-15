using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region fibonacci task
            Console.Write("Add a number: ");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            int lastDigit = 1;
            int previousDigit = 0;
            int firbonacciNumber = 0;

            while(givenNumber>firbonacciNumber)
            {
                Console.Write(firbonacciNumber + " ");
                previousDigit = lastDigit;
                lastDigit = firbonacciNumber;
                firbonacciNumber = lastDigit + previousDigit;
            }
            Console.ReadLine();
            #endregion
        }
    }
}
