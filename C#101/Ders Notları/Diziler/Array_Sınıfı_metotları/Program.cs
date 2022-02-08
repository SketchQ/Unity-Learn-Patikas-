using System;

namespace Array_Class_methods
{
    internal class Program
    {

        // HackerRank BirthdayCakeCandles Function
        public static int birthdayCakeCandles(List<int> candles)
        {
            try
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
            catch (System.Exception)
            {
                return 0;
                throw;
            }

        }

        // HackerRank simpleArraySum Function
        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            foreach (int num in ar)
            {
                sum += num;
            }
            return sum;
        }

        // HackerRank aVeryBigSum Function
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach (long num in ar)
            {
                sum += num;
            }
            return sum;
        }

        // HackerRank compareTriplets Function
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            // Complete this function
            int alice = 0;
            int bob = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (a[i] < b[i])
                {
                    bob++;
                }
                else
                {
                    continue;
                }
            }

            List<int> result = new List<int>();
            result.Add(alice);
            result.Add(bob);
            return result;

        }

        // HackerRank migratoryBirds Function

        static int NUM_TYPES = 5;
        public static int migratoryBirds(List<int> ar)
        {
            // Complete this function
            // time limit exceeded
            // int bird = 0;
            // int count = 0;
            // int max = 0;

            // for (int i = 0; i < ar.Count; i++)
            // {
            //     for (int j = 0; j < ar.Count; j++)
            //     {
            //         if (ar[i] == ar[j])
            //         {
            //             count++;
            //         }
            //     }
            //     if (count > max)
            //     {
            //         max = count;
            //         bird = ar[i];
            //     }
            //     count = 0;
            // }
          
            // return bird;

            // better solution for time limit exceeded
            // get count of each bird
            int[] count = new int[NUM_TYPES + 1];
            foreach (int bird in ar)
            {
                count[bird]++;
            }

            // find max count
            int max = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > count[max])
                {
                    max = i;
                }
            }

            return max;       


         
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

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the height of the {0} candle : ", i + 1);
                candles.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int result = Program.birthdayCakeCandles(candles);
            Console.WriteLine("The number of tallest candles are : " + result);

            // HackerRank Simple Array Sum
            Console.WriteLine("\n*****HackerRank Simple Array Sum ******");
            // Given an array of integers, find the sum of its elements.
            Console.WriteLine("Enter the size of the array : ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>(size1);

            for (int i = 0; i < size1; i++)
            {
                Console.WriteLine("Enter the {0} element of the array : ", i + 1);
                arr.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int result1 = Program.simpleArraySum(arr);
            Console.WriteLine("The sum of the array elements is : " + result1);



            Console.WriteLine("\n******* Array Reverse Method ********");
            // Given an array, reverse the order of the elements in the array.
            Console.WriteLine("Enter the size of the array : ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            List<int> arr2 = new List<int>(size2);
            for (int i = 0; i < size2; i++)
            {
                Console.WriteLine("Enter the {0} element of the array : ", i + 1);
                arr2.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // Reverse the array based on index numbers
            for (int i = arr2.Count - 1; i >= 0; i--)
            {
                Console.Write(arr2[i] + ",");
            }


            Console.WriteLine("\n******* Very Big Sum Function ********");
            // Given an array of integers, find the sum of its elements.
            // Some of the integers may be very large,
            // so you need to take care of integer overflow.
            Console.WriteLine("Enter the size of the array : ");
            int size3 = Convert.ToInt32(Console.ReadLine());
            List<long> arr3 = new List<long>(size3);
            for (int i = 0; i < size3; i++)
            {
                Console.WriteLine("Enter the {0} element of the array : ", i + 1);
                arr3.Add(Convert.ToInt32(Console.ReadLine()));
            }

            long result3 = Program.aVeryBigSum(arr3);
            Console.WriteLine("The sum of the array elements is : " + result3);

            Console.WriteLine("\n******* HackerRank Compare the Triplets ********");
            // Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, 
            // awarding points on a scale from 1 to 100 for three categories: problem clarity, originality, and difficulty.

            // Creating the Triplets for Alice and Bob
            List<int> alice = new List<int>(3);
            List<int> bob = new List<int>(3);

            // Filling up the Triplets
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Enter the {0} element of Alice's array : ", i + 1);
                alice.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Enter the {0} element of Bob's array : ", i + 1);
                bob.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // Calling the Compare the Triplets Function
            List<int> result4 = Program.compareTriplets(alice, bob);

            Console.WriteLine(String.Join(" ", result4));

            Console.WriteLine("\n******* HackerRank Bubble Sort ********");
            // Given an array of integers, sort the array in ascending order.
            // The bubble sort algorithm should be used to solve this problem.
            Console.WriteLine("Enter the size of the array : ");
            int size4 = Convert.ToInt32(Console.ReadLine());
            List<int> arr4 = new List<int>(size4);
            for (int i = 0; i < size4; i++)
            {
                Console.WriteLine("Enter the {0} element of the array : ", i + 1);
                arr4.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // Bubble Sort the array
            int count = 0;
            for (int i = 0; i < arr4.Count; i++)
            {
                for (int j = 0; j < arr4.Count - 1; j++)
                {
                    if (arr4[j] > arr4[j + 1])
                    {
                        int temp = arr4[j];
                        arr4[j] = arr4[j + 1];
                        arr4[j + 1] = temp;
                        count++;
                    }
                }
            }
            Console.WriteLine("Array is sorted in " + count + " swaps.");
            Console.WriteLine("First Element: " + arr4[0]);
            Console.WriteLine("Last Element: " + arr4[arr4.Count - 1]);

            Console.WriteLine("\n******* HackerRank Migratory Birds ********");
            //Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type. 
            // If more than 1 type has been spotted that maximum amount, return the smallest of their ids.

            Console.WriteLine("Enter the size of the array : ");
            int size5 = Convert.ToInt32(Console.ReadLine());
            List<int> arr5 = new List<int>(size5);
            for (int i = 0; i < size5; i++)
            {
                Console.WriteLine("Enter the {0} element of the array : ", i + 1);
                arr5.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // Calling the Migratory Birds Function
            int result5 = Program.migratoryBirds(arr5);
            Console.WriteLine("The most frequent bird is : " + result5);

        }
    }
}