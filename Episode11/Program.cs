using System;

namespace Episode11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 5;

            bool karsilastir = a == b && a == c;

            Console.WriteLine(karsilastir);

            // ve operatörü
            System.Console.WriteLine("Ve Operatörü");
            System.Console.WriteLine("true && true = " + (true && true));
            System.Console.WriteLine("true && false = " + (true && false));
            System.Console.WriteLine("false && true = " + (false && true));
            System.Console.WriteLine("false && false = " + (false && false));

            System.Console.WriteLine();

            // veya operatörü
            System.Console.WriteLine("Veya Operatörü");
            System.Console.WriteLine("true || true = " + (true || true));
            System.Console.WriteLine("true || false = " + (true || false));
            System.Console.WriteLine("false || true = " + (false || true));
            System.Console.WriteLine("false || false = " + (false || false));

            System.Console.WriteLine();

            // Değil Operatörü
            System.Console.WriteLine("Değil Operatörü");
            System.Console.WriteLine("!true = " + (!true));
            System.Console.WriteLine("!false = " + (!false));


            System.Console.WriteLine(b <= a && a >= c);

            System.Console.WriteLine(b <= a || a >= c);
            System.Console.WriteLine(a < c && b > a);
        }
    }
}
