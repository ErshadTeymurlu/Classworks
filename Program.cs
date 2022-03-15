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
            //Console.Write("Add a number: ");
            //int givenNumber = Convert.ToInt32(Console.ReadLine());
            //int lastDigit = 1;
            //int previousDigit = 0;
            //int firbonacciNumber = 0;

            //while(givenNumber>firbonacciNumber)
            //{
            //    Console.Write(firbonacciNumber + " ");
            //    previousDigit = lastDigit;
            //    lastDigit = firbonacciNumber;
            //    firbonacciNumber = lastDigit + previousDigit;
            //}
            //Console.ReadLine();
            #endregion
            #region Bubble Sort
            //int[] array = new int[] { 1, 6, 2, 78, 6, 8, 7, 10 };
            //int temp = 0;
            //bool swapped = false;
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = 0; j < array.Length - 1; j++)
            //    {
            //        if (array[j] > array[j + 1])
            //        {
            //            swapped = true;
            //            temp = array[j + 1];
            //            array[j + 1] = array[j];
            //            array[j] = temp;
            //        }
            //    }
            //    if(!swapped)
            //     {
            //       break;
            //      }
            //}
            //foreach (int item in array)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadLine();
            #endregion
            #region Interchange array max and min elements
            //Console.Write("Add array size: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[size];
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{i + 1} element:");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int minIndex = 0, maxIndex = 0;
            //for(int i = 0; i < array.Length; i++)
            //{
            //    if (array[0] > array[i]) minIndex = i;
            //    else if(array[0] < array[i]) maxIndex = i;
            //}
            //Console.WriteLine();
            //int temp = array[maxIndex];
            //array[maxIndex] = array[minIndex];
            //array[minIndex] = temp;
            //foreach (int item in array) Console.Write(item + " ");
            //Console.ReadLine();
            #endregion
            #region task2
            //Console.Write("Add: ");
            //string given = Console.ReadLine();
            //string given1 = "";
            //foreach (char letter in given)
            //{
            //    if (letter != 'a') given1 = given1 + letter;
            //    else if (letter == 'a') given1 = given1 + 'e';
            //}
            //given = given1;
            //Console.WriteLine(given);
            //Console.ReadLine();
            #endregion
            #region task3
            //Console.Write("Add: ");
            //string given = Console.ReadLine();
            //char[] letters = { 'a', 'i', 'o', 'u', 'e' };
            //int count = 0;
            //for (int i = 0; i < given.Length; i++)
            //{
            //    for (int j = 0; j < letters.Length; j++)
            //    {
            //        if (given[i] == letters[j]) count++;
            //    }
            //}
            //Console.WriteLine("Sait seslerin sayi: " + count);
            //Console.ReadLine();
            #endregion
        }
    }
}
