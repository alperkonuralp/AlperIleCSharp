using System;

namespace Episode12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            if (a == b)
            {
                System.Console.WriteLine($"a = {a}");
                System.Console.WriteLine($"b = {b}");
                System.Console.WriteLine("a == b");
            }
            else if (a < b)
            {
                System.Console.WriteLine("a < b");
            }
            else
            {
                System.Console.WriteLine("a > b");
            }

        }
    }
}
