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
            #region Average
            //int[] array = { 1, 2, 3, 7, 4, 23, 6, 3 };
            //int average;
            //CalculateAverage(array, out average);
            #endregion
            #region MtoN
            //Console.Write("Add first number: ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Add last number: ");
            //int lastNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sum is "+Sum(firstNumber,lastNumber));
            //Console.ReadLine();
            #endregion
            #region MtoN Average
            //Console.Write("Add first number: ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Add last number: ");
            //int lastNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Average: " + Average(firstNumber, lastNumber));
            //Console.ReadLine();
            #endregion
            #region Inter Change Max And Min
            //int[] arr = { 19, 32, 6, 3, 7, 2, 8 };
            //InterChangeMaxAndMin(ref arr);
            //foreach (var item in arr) Console.Write(item + " ");
            //Console.ReadLine();
            #endregion
            #region Minus To Plus
            //int[] array = { 19, -32, 6, 3, -7, 2, -8 };
            //MinusToPlus(array);
            //foreach (var item in array) Console.Write(item+ " ");
            //Console.ReadLine();
            #endregion
            #region Task 5
            //Console.Write("Add number: ");
            //int givenNumber = Convert.ToInt32(Console.ReadLine());
            //Reverse(ref givenNumber);
            //Console.WriteLine(givenNumber);
            //Console.ReadLine();
            #endregion
        }
        static void Reverse(ref int givenNumb)
        {
            int reverse = 0, numb = givenNumb;
            while (numb>0)
            {
                reverse = reverse * 10 + numb % 10;
                numb = numb / 10;
            }
            givenNumb = reverse;
        }
        static void MinusToPlus(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i] * (-1);
                }
                
            }
        }
        static void InterChangeMaxAndMin(ref int[] array)
        {
            int minIndx = 0, maxIndx = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[minIndx]>array[i])
                {
                    minIndx = i;
                    array[minIndx] = array[i];
                }
                if (array[maxIndx] < array[i])
                {
                    maxIndx = i;
                    array[maxIndx] = array[i];
                }
            }
            array[minIndx] = array[maxIndx] + array[minIndx];
            array[maxIndx] = array[minIndx] - array[maxIndx];
            array[minIndx] = array[minIndx] - array[maxIndx];
        }
        static void check( ref int first,ref int last)
        {
            if (first > last)
            {
                first = first + last;
                last = first - last;
                first = first - last;
            }
        }
        static int Average(int fistNumb, int lastNumb)
        {
            int sum = 0;
            check(ref fistNumb, ref lastNumb);
            for (int i = fistNumb; i < lastNumb; i++)
            {
                if(i%15 ==0) sum = sum + i;
            }
            return sum;
        }
        static int Sum(int fistNumb, int lastNumb)
        {
            int sum = 0;
            check(ref fistNumb, ref lastNumb);
            for (int i = fistNumb; i < lastNumb; i++)
            {
                    sum = sum + i;
            }
            return sum;
        }
        static void CalculateAverage(int[] arr,out int average)
        {
            average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                average = average + arr[i];
            }
            average = average / arr.Length;
            Console.Write("Average is " + average);

        }
    }
}
