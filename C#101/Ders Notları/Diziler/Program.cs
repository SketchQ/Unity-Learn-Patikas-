using System;

namespace diziler
{
    internal class Program
    {   


        public static void plusMinus(List<int> arr)
        {
            int plus = 0;
            int minus = 0;
            int zero = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    plus++;
                }
                else if (arr[i] < 0)
                {
                    minus++;
                }
                else
                {
                    zero++;
                }
            }
            Console.WriteLine((double)plus / arr.Count);
            Console.WriteLine((double)minus / arr.Count);
            Console.WriteLine((double)zero / arr.Count);
        }
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            // 5 adet elemandan oluşan colors isimli dizi tanımladık.
            string[] colors = new string[5];
            // Diziye elemanları ekleyerekde tanımlayabiliriz.
            string[] animals = { "Cat", "Dog", "Bird", "Monkey" };
            // Bu şekilde de tanımlayabiliriz.
            int[] dizi;
            dizi = new int[5];

            // Dizilere  değer Atama ve Erişim
            // Colors isimli diziye eleman atama
            colors[0] = "Blue";
            // animals isimli dizideki elemana erişim
            Console.WriteLine("Reading the item in list 'animals':  " + animals[0]);
            // Dizi isimli diziye eleman ekleme
            dizi[3] = 10;

            // Console'a yazdırma
            Console.WriteLine("Colors array first item:  " + colors[0]);
            Console.WriteLine("Animals array first second item: " + animals[1]);
            Console.WriteLine("Dizi array forth item: " + dizi[3]);

            Console.WriteLine("************************");

            // Döngülerle diziler
            // Klavye'den girilen 'n' tane sayının ortalamasını alan program
            Console.WriteLine("Enter the length of an array: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] exampleArray = new int[N];

            // Diziye eleman ekleme
            for (int i = 0; i < N; i++)
            {
                Console.Write("Please enter {0}, number: ", i + 1);
                exampleArray[i] = Convert.ToInt32(Console.ReadLine());     
            }

            int sum = 0;
            foreach (var num in exampleArray)
                sum += num;    
                    
            Console.WriteLine("Avarage is : " + sum / N);

            Console.WriteLine("**********HackerRank**************");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Program.plusMinus(arr);
        }
    }
}