using System;

namespace FifthEpisode
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine($"a = {a}");

            int b = 19;
            Console.WriteLine($"b = {b}");

            int c = a + b;
            Console.WriteLine($"c = {c}");

            int d = a + b + 25;
            Console.WriteLine($"d = {d}");

            int e = a - b;
            Console.WriteLine($"e = {e}");

            int f = a * b;
            Console.WriteLine($"f = {f}");

            int g = a / b;
            Console.WriteLine($"g = {g}");

            int h = 21 / a;
            Console.WriteLine($"h = {h}");

            int i = a % 2; // mod alma.
            Console.WriteLine($"i = {i}");

            double j = 5;
            Console.WriteLine($"j = {j}");
            
            double k = 19;
            Console.WriteLine($"k = {k}");

            double l = j + k;
            Console.WriteLine($"l = {l}");

            double m = j / k;
            Console.WriteLine($"m = {m}");

            double n = a / b;
            Console.WriteLine($"n = {n}");

            double o = (double)a / b;
            Console.WriteLine($"o = {o}");

            double p = a * 1.0 / b;
            Console.WriteLine($"p = {p}");
        }
    }
}
