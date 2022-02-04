using System;

namespace Hata_Yonetimi
{
    class program
    {
        public static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter a number: ");
                int sayi = Convert.ToInt32(Console.ReadLine()); // eğer sayı girilmezse hata verir.
                Console.WriteLine("Your number is: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            finally
            {   // Hata olsun olmasın kullanıcıya bu mesajı verir
                Console.WriteLine("Program finished");

            }


            try
            {
                //int b = int.Parse(null); // Arayüzde null değerini girerse hata verir.
                //int a = int.Parse("abc"); // Arayüzde string değerini girerse hata verir.
                int c = int.Parse("-200000000000"); // Overflow hatası verir. 

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                Console.WriteLine(ex);
            }
            catch (FormatException ex) {
                Console.WriteLine("Error: " + ex.Message.ToString());
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Program finished");
            }






        }
    }
}