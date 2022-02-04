using System;

namespace Tip_Donusumlerı
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Tip Dönüşümleri
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Erim";
            char f = 'e';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("\n\n\n");

            int x = 4;
            byte y = (byte)x; // parentez içinde yazılan veri tipine değiştirir.
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // **** ToString() Metotu ****
            Console.WriteLine("\n\n\n");

            int xx = 6;
            string yy = xx.ToString(); // int tipinden string tipine dönüştürülür.
            Console.WriteLine("yy: " + yy);

            string ff = 12.5f.ToString(); // float tipinden string tipine dönüştürülür.
            Console.WriteLine("ff: " + ff);

            // **** System.Convert Metotu ****
            Console.WriteLine("\n\n\n");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int sum;

            sayi1 = Convert.ToInt32(s1);    // string tipinden int tipine dönüştürülür.
            sayi2 = Convert.ToInt32(s2);    // string tipinden int tipine dönüştürülür.
            sum = sayi1 + sayi2;            // int tipinden int tipine dönüştürülür.
            Console.WriteLine("sum: " + sum); // sum: 30

            // **** Parse() Metotu *****
            Console.WriteLine("\n\n\n");

            string zz = "10";
            int tt = int.Parse(zz); // string tipinden int tipine dönüştürülür.
            Console.WriteLine("tt: " + tt);

            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = int.Parse(metin1); // string tipinden int tipine dönüştürülür.
            double1 = double.Parse(metin2); // string tipinden double tipine dönüştürülür.
            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);

        }
    }
}