using System;

namespace degisken {
    class Program {
        public static void Main(string[] args) {
            int deger = 2;
            Console.WriteLine("deger = {0}", deger);

            // Data types
            byte b = 5; // 1 byte = 8 bit
            sbyte c = 5; // 1 byte = 8 bit

            short s =5; // 2 byte = 16 bit
            ushort u = 5; // 2 byte = 16 bit

            int i = 5; // 4 byte = 32 bit
            Int16 i16 = 5; // 4 byte = 32 bit
            Int32 i32 = 5; // 4 byte = 32 bit
            Int64 i64 = 5; // 8 byte = 64 bit

            uint ui = 5; // 4 byte = 32 bit
            long l = 5; // 8 byte = 64 bit
            ulong ul = 5; // 8 byte = 64 bit

            // Reel sayılar
            float f = 5.5f; // 4 byte = 32 bit
            double d = 5.5; // 8 byte = 64 bit
            decimal de = 5.5m; // 16 byte = 128 bit

            char c1 = 'a'; // 2 byte = 16 bit
            char c2 = '\u0061'; // 2 byte = 16 bit

            string s1 = "a"; // sınırsız bit
            string s2 = "a\u0061"; // sınırsız bit

            bool bb = true; // 1 byte = 8 bit

            // Datetime
            DateTime dt = DateTime.Now;
            Console.WriteLine("dt = {0}", dt);

            // Object type -- Her türlü değişkeni tanımlayabiliriz.
            object o = 5; // 4 byte = 32 bit
            object o1 = 5.5; // 8 byte = 64 bit
            object o2 = true; // 1 byte = 8 bit
            object o3 = 'a'; // 2 byte = 16 bit
            object o4 = "Erim"; // sınırsız bit

            Console.WriteLine("b = {0}", b);
            Console.WriteLine("c = {0}", c);
            Console.WriteLine("s = {0}", s);
            Console.WriteLine("u = {0}", u);
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("i16 = {0}", i16);
            Console.WriteLine("i32 = {0}", i32);
            Console.WriteLine("i64 = {0}", i64);
            Console.WriteLine("ui = {0}", ui);
            Console.WriteLine("l = {0}", l);
            Console.WriteLine("ul = {0}", ul);
            Console.WriteLine("f = {0}", f);
            Console.WriteLine("d = {0}", d);
            Console.WriteLine("de = {0}", de);
            Console.WriteLine("bb = {0}", bb);
            Console.WriteLine("c1 = {0}", c1);
            Console.WriteLine("c2 = {0}", c2);
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine("o = {0}", o);
            Console.WriteLine("o1 = {0}", o1);
            Console.WriteLine("o2 = {0}", o2);
            Console.WriteLine("o3 = {0}", o3);
            Console.WriteLine("o4 = {0}", o4);


            // String ifadeler
            string str1 = string.Empty; // boş string
            string str2 = ""; // boş string
            str1= "Erim"; // string
            str2 = "Serdönmez"; // string
            string full = str1 + str2; // string
            Console.WriteLine(full);


            // Integer tanımlama şekilleri
            int integer1 = 10; // int
            int integer2 = 24; // int
            int mul = integer1 * integer2; // int çarpımı


            // boolean
            bool boolean1 = true; // bool
            bool boolean2 = false; // bool
            boolean1 = integer1 > integer2; // bool sonuç
            boolean2 = integer1 < integer2; // bool sonuç


            // Değişken Dönüşümleri
            string str20 = "20"; // string
            int int20 = 20; // int

            string newString = str20 + int20.ToString(); // ToString -- metotu ile stringe çevirebiliriz.
            Console.WriteLine(newString);
            int newInt = int20 + Convert.ToInt32(str20); // Convert.ToInt32(str) -- metotu ile inte çevirebiliriz.(Başka tipleride değiştirebiliriz)
            Console.WriteLine(newInt);

            int int22 = int20 + int.Parse(str20); // int.Parse(str) -- metotu ile de inte çevirebiliriz. (Sadece String çevirir)
            Console.WriteLine(int22);

            // DateTime
            string datetime = DateTime.Now.ToString(); // DateTime tipini stringe çevirir.
            Console.WriteLine(datetime); // Saati de verir
            string dateTimeFormatted = DateTime.Now.ToString("dd/MM/yyyy"); // DateTime tipini stringe çevirir.
            Console.WriteLine(dateTimeFormatted); // Sadece Tarihi verir.
            string dateTimeHour = DateTime.Now.ToString("HH:mm"); // DateTime tipini stringe çevirir.
            Console.WriteLine(dateTimeHour); // Sadece Saati verir.
        }
    }
}