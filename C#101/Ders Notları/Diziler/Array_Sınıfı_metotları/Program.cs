using System;

namespace Array_Class_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sort Method
            // Yeni diziyi tanımlamak
            int[] numberArr = {23,12,4,86,72,3,11,17};
            
            Console.WriteLine("UnSorted list : ");
            
            // Sıralama olmadan console'a yazdıralım.
            foreach (var num in numberArr)
            {
                Console.Write(num + "," );
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
            Array.Clear(numberArr,2,2);

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

            Array.IndexOf(numberArr,23);
            
            Console.WriteLine(Array.IndexOf(numberArr,23));

            // Resize Method
            Console.WriteLine("***** Resize Method *****");
            // diziye yeni bir boyut atar.
            Array.Resize<int>(ref numberArr, 9);
            numberArr[8] = 99;

            foreach (var item in numberArr)
            {   
                Console.Write(item + ",");
            }
        }
    }
}