using System;

namespace ForthEpisode
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 1.2F; // 4 byte
            double d = 2.4; // 8 byte

            float f2 = 3.4789F + 78.1135F;
            double d2 = 3.4789 + 78.1135;

            double d3 = f2;
            // double d3 = (double)f2; // bu şekilde de yazılabilir. Zorunlu değil.

            float f3 = (float)d2; 

            int i = 123;
            float f4 = i;
            double d4 = i;

            Console.WriteLine(i == 123);

            double d5 = 24.7699999999;
            Console.WriteLine(Math.Abs(d5 - 24.77) < 0.01);

            decimal dec = 1235.64556456456412M;
        }
    }
}
