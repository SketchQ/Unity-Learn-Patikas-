﻿using System;

namespace Array_Class_methods
{
    internal class Program
    {

        // HackerRank BirthdayCakeCandles Function
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int count = 0;
            foreach (int candle in candles)
            {
                if (candle == max)
                {
                    count++;
                }
            }
            return count;
        }


        static void Main(string[] args)
        {
            // Sort Method
            // Yeni diziyi tanımlamak
            int[] numberArr = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("UnSorted list : ");

            // Sıralama olmadan console'a yazdıralım.
            foreach (var num in numberArr)
            {
                Console.Write(num + ",");
            }

            Console.WriteLine("\nSorted List :");
            // Array.Sort(arr) --> Metotu
            Array.Sort(numberArr);
            // Sıralı bir şekilde console'a yazdırma
            foreach (var num in numberArr)
            {
                Console.Write(num + ",");
            }

            // Clear Methodu
            Console.WriteLine("\n****** Array Clear Method ******");
            // Dizideki elemanları kullanarak 2. indisten itibaren 2 tane elemana 0 atar.
            Array.Clear(numberArr, 2, 2);

            foreach (var item in numberArr)
            {
                Console.Write(item + ",");
            }

            // Reverse Methodu
            Console.WriteLine("\n***** Reverse Method *****");

            Array.Reverse(numberArr);

            foreach (var item in numberArr)
            {
                Console.Write(item + ",");
            }

            // IndexOf Method
            Console.WriteLine("\n***** IndexOf Method *****");

            Array.IndexOf(numberArr, 23);

            Console.WriteLine(Array.IndexOf(numberArr, 23));

            // Resize Method
            Console.WriteLine("***** Resize Method *****");
            // diziye yeni bir boyut atar.
            Array.Resize<int>(ref numberArr, 9);
            numberArr[8] = 99;

            foreach (var item in numberArr)
            {
                Console.Write(item + ",");
            }

            // HackerRank Problems
            Console.WriteLine("\n***** HackerRank Problems *****");

            // You are in charge of the cake for a child's birthday. 
            // You have decided the cake will have one candle for each year of their total age.
            // They will only be able to blow out the tallest of the candles.
            // Count how many candles are tallest.
            Console.WriteLine("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            List<int> candles = new List<int>(size);

            for (int i = 0; i < size ; i++)
            {
                Console.WriteLine("Enter the height of the {0} candle : ", i + 1);
                candles.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int result = Program.birthdayCakeCandles(candles);
            Console.WriteLine("The number of tallest candles are : " + result);

        }
    }
}