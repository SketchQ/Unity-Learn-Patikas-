// See https://aka.ms/new-console-template for more information
using System;

namespace Switch_Case {
    class Program {
        static void Main(string[] args) {

            int month = DateTime.Now.Month;

            // Expression
            switch (month) {
                case 1 :
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2 :
                    Console.WriteLine("Şubat ayındayısınız.");
                    break;
                case 6 :
                    Console.WriteLine("Haziran ayındasınız.");
                    break;
                default:
                    Console.WriteLine("Yanlış veri!!");
                    break;
            }


            // Switch case içerisinde aşağıdaki gibi birden fazla condition verilebilinir.    
            switch (month) {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Aylarındasınız.");
                    break;
                case 3 :
                case 4 :
                case 5 :
                    Console.WriteLine("Bahar Aylarındasınız.");
                    break;
                default :
                break;
            }
        }
    }
}



