// See https://aka.ms/new-console-template for more information
using System;

namespace if_else_if {
    class Program {
        static void Main(string[] args) {

            // Programın çalıştığı saati time variable adına kaydediyoruz
            int time = DateTime.Now.Hour;

            // Eğer zaman 6 ile 11 arasında ise aşağıdaki kod bloğu çalışır.
            if (time >= 6 && time < 11) {
                Console.WriteLine("Günaydın!!");
            }
            // Eğer 18'den küçük ise aşağıdaki
            else if (time <= 18) {
                Console.WriteLine("İlk_İyi Günler!!");
            }
            // Diğer geri kalan durumlarda ise aşağıdaki kod çalışır
            else {
                Console.WriteLine("İyi Geceler!!");
            }

            // Aşağıdaki gibi tek satır halinde de if kod bloğu yazılabilir.
            string result = time <= 18 ? "İkinci_İyi Günler!!" : "İyi Geceler!!";
            string sonuc = time >= 6 && time < 11 ? "Günaydın!!" : time < 18 ? "Üçünçü_İyi Günler!" : "İyi Geceler!";
            Console.WriteLine(result);
            Console.WriteLine(sonuc);

        }
    }
}