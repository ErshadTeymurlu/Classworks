using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MarchClasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 7, 4, 23, 6, 3 };
            int average;
            CalculateAverage(array, out average);
            
            Console.ReadLine();
        }
        static void CalculateAverage(int[] arr,out int average)
        {
            average = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                average = average + arr[i];
            }
            average = average / arr.Length;
            Console.Write("Average is " +average);
            
        }
    }
}
