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
            #region Bubble Sort with method
            //int[] array = { 4,12,17,93,24,42,
            //};
            //BubbleSort(array);
            //Console.ReadLine();

            #endregion
            #region First Task
            //Console.Write("Add a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //AmountOfPlaces(number);
            //Console.ReadLine();
            #endregion
            #region Smallest Index In Array
            //int[] array = { 15, 5, 2, 67, 4, 7, 65 };
            //Console.WriteLine("Smallest index is: " + SmallestIndexOfArray(array));
            //Console.ReadLine();
            #endregion
            #region PowerOfTwo
            //Console.Write("Add number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Power of two: "+PowerOfTwo(number)); 
            //Console.ReadLine();
            #endregion
            #region AmountOfWords
            //Console.Write("Add a sentence: ");
            //string sentence = Console.ReadLine();
            //Console.WriteLine("Amount of words is " + AmountOfWords(sentence));
            //Console.ReadLine();
            #endregion
            #region PrimeOrComposite
            //Console.Write("Add a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //PrimeOrComposite(number);
            //Console.ReadLine();
            #endregion
            #region DigitsSumAndMultiply
            //Console.Write("Add number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ferq: "+SumAndMultiplication(number));
            //Console.ReadLine();
            #endregion
            #region Bigger Amoung Given Numbers
            //Console.WriteLine("Bigger number is "+FindBigger(1, 643, 12, 43, 2, 6, 23));
            //Console.ReadLine();
            #endregion



        }
        static int FindBigger(params int[] numbers)
        {
            int maxIndx = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[maxIndx] < numbers[i])
                {
                    maxIndx = i;
                }
            }
            return numbers[maxIndx];
        }
        static int SumAndMultiplication(int givenNumber)
        {
            int sum = 0, multiply = 1;
            while (givenNumber > 0)
            {
                sum = sum + givenNumber % 10;
                multiply = multiply * (givenNumber % 10);
                givenNumber = givenNumber / 10;
            }
            return multiply - sum;
        }
        static void PrimeOrComposite(int givenNumber)
        {
            bool check = true;
            for(int i = 2; i*i < givenNumber; i++)
            {
                if (givenNumber % i == 0)
                {
                    Console.WriteLine("Number is composite");
                    check = false;
                    break;
                }
            }
            if (check == true) Console.WriteLine("Number is prime.");
        }
        static int AmountOfWords(string givenSentence)
        {
            int count = 1;
            if (givenSentence != "")
            {
                for (int i = 0; i < givenSentence.Length; i++)
                {
                    if (givenSentence[i] == ' ' || givenSentence[i] == '.' || givenSentence[i] == ',' || givenSentence[i] == '!')
                    {
                        count++;
                    }
                }
                return count;
            }
            return 0;
            
        }
        static int PowerOfTwo(int num)
        {
            int count = 0;
            bool check = true;
            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    count++;   
                }
                else 
                {
                    check = false;
                    break;
                }
                num = num / 2;
            }
            if (check == true) return count;
            return 0;
        }
        static int SmallestIndexOfArray(int[] arr)
        {
            int minIndx = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[minIndx] > arr[i])
                {
                    minIndx = i;
                }
            }
            return minIndx;
        }
        static void AmountOfPlaces(int givenNumber)
        {
            int count = 0;
            if (givenNumber < 0) givenNumber = givenNumber * (-1);
            while (givenNumber > 0)
            {
                givenNumber = givenNumber / 10;
                count++;
            }
            Console.WriteLine("Amount of Places: " + count);
        }
        static void BubbleSort(int[] numbers)
        {
            bool swapped = false;
            int loopcount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    loopcount++;
                    if (numbers[j] > numbers[j + 1])
                    {
                        swapped = true;

                        numbers[j + 1] = numbers[j] + numbers[j + 1];
                        numbers[j] = numbers[j + 1] - numbers[j];
                        numbers[j + 1] = numbers[j + 1] - numbers[j];


                    }
                }
                if (!swapped) break;
            }
            foreach (var item in numbers) Console.Write(item + " ");
            Console.WriteLine("Loop count: " + loopcount);
        }





    }
}
