using System;

namespace Donguler_While_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // 1'den başlayarak console'dan girilen sayıya kadar (Sayı dahil) ortalama hesaplayıp console'a yazdıran program
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            int sum = 0;

            while (count <= number)
            {
                // Kod bloğu
                sum += count;
                count++;
            }

            Console.WriteLine(sum / number);

            Console.WriteLine("************");

            // 'a' dan 'z' ye kadar tüm harfleri console'a yazdır.
            char ch = 'a';

            while (ch < 'z')
            {
                Console.Write(ch);
                ch++;
            }


            Console.WriteLine("\n****** Foreach *******");
            // Dizi tanımlama
            string[] cars = {"BMW", "Ford","Toyota","Nissan"};

            foreach (var car in cars)
            {   
                Console.WriteLine(car);
            }    
        }
    }
}