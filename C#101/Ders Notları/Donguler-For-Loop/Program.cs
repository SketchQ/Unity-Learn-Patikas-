using System;

namespace donguler_for_loop
{

    class Program
    {

        static void Main(string[] args)
        {

            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Enter a number: ");
            int countdown = int.Parse(Console.ReadLine()); // Readline string olarak veri alır.
            for (int i = 0; i <= countdown; i++)
            {
                // kod bloğu
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("***********************");
            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içerisindeki toplamlarını ekrana yazdır.
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += i; // Tek Toplam = tektoplam + i
                }
                else
                {
                    evenSum += i; // Çift toplam = Çift Toplam + i
                }
            }

            Console.WriteLine("Sum of Odd Numbers: " + oddSum + "\n" + "Sum of Even Numbers: " + evenSum);

            // break, continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    // i = 4 olduğunda döngüyü kırar
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    // i = 4 olduğunda 4'ü atlar ve devam eder.
                    continue;
                Console.WriteLine(i);
            }

            // Staircase 
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
 

        }
    }
}