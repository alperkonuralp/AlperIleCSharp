using System;

namespace SecondEpisode
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; 
            int b = default;
            int c = 125;
            int d = 54;

            a = 5; 

            d = a + b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            
        }
    }
}
