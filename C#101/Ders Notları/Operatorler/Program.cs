using System;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama
            int x = 3;
            int y = 3;

            x = x + 2; // ya da
            Console.WriteLine("Uzun yoldan x'in değeri : " + x); // 5
            Console.WriteLine("İşlemli Atama");
            y += 2; // İşlemli Atama
            Console.WriteLine(y);  // 5

            // İşlemli Atamalar
            y /= 2; // y'nin 2'ye bölünüp y'ye atanır.
            Console.WriteLine(y); // 2
            y *= 2; // y'nin 2'ye çarpılıp y'ye atanır.
            Console.WriteLine(y); // 4
            y -= 2; // y'nin 2'yi azaltıp y'ye atanır.
            Console.WriteLine(y); // 2
            y %= 2; // y'nin 2'yi bölüp y'ye atanır. (Mod)

            // Mantıksal Operatörler
            // ||(or), &&(and), !(not)
            Console.WriteLine("Mantıksal Operatörler");

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted) {
                Console.WriteLine("Perfect"); // Skip
            }
            if (isSuccess || isCompleted) {
                Console.WriteLine("Not Perfect"); // printed
            }
            if (!isSuccess) {
                Console.WriteLine("Not Success"); // skip
            }
            if (!isSuccess && !isCompleted) {
                Console.WriteLine("Not Success and Not Completed"); // skip
            }

            // İlişkisel Operatörler
            // ==(equal), !=(not equal), >(greater than), <(less than), >=, <=
            Console.WriteLine("İlişkisel Operatörler");

            int a = 3;
            int b = 4;
            bool result = a < b; 

            Console.WriteLine(result);  // false
            result = a > b;
            Console.WriteLine(result);  // true
            result = a == b;
            Console.WriteLine(result);  // false
            result = a != b;
            Console.WriteLine(result);  // true
            result = a >= b;
            Console.WriteLine(result);  // false
            result = a <= b;
            Console.WriteLine(result);  // true

            // Aritmetik Operatörleri
            // + - * / %
            Console.WriteLine("Aritmetik Operatörleri");

            int c = 3;
            int d = 4;

            Console.WriteLine(c + d); // 7
            Console.WriteLine(c - d); // -1
            Console.WriteLine(c * d); // 12
            Console.WriteLine(c / d); // 0
            Console.WriteLine(c % d); // 3

            // ++(increment), --(decrement)
            Console.WriteLine("++(increment), --(decrement)");

            int e = 3;
            int f = 4;

            Console.WriteLine(e++); // output 3 olur ve e'nin değeri 4 olur.
            Console.WriteLine(e); // 4 olur.
            Console.WriteLine(--e); // 3 olur. e'nin değeri 3 olur.

            Console.WriteLine(++f); // 5
            Console.WriteLine(f); // 5
            Console.WriteLine(f--); // 5


        }
    }
} 