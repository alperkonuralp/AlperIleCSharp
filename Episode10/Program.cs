using System;

namespace Episode10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true; // false

            kontrol = (5 == 3);

            bool gectimi = false;

            // ....

            gectimi = true;


            // Eşitlik
            Console.WriteLine(5 == 3);

            // Eşit değillik
            Console.WriteLine(5 != 3);

            // Büyük 
            Console.WriteLine(5 > 3);

            // Küçük
            Console.WriteLine(5 < 3);

            // Büyük veya Eşit
            Console.WriteLine(5 >= 3);

            // Küçük veya Eşit
            Console.WriteLine(5 <= 3);

        }
    }
}
