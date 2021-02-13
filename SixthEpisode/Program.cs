using System;

namespace SixthEpisode
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5; // 4 byte

            uint b = 5; // 4 byte

            Console.WriteLine($"int min = {int.MinValue}, max = {int.MaxValue}");
            Console.WriteLine($"uint min = {uint.MinValue}, max = {uint.MaxValue}");
            /*
            int - uint // 4 byte
            short - ushort // 2 byte
            long - ulong // 8 byte
            */

            Console.WriteLine($"byte min = {byte.MinValue}, max = {byte.MaxValue}");
            Console.WriteLine($"sbyte min = {sbyte.MinValue}, max = {sbyte.MaxValue}");

            // 1 000 000 000.0  = 1000000000.0 = 1E9
            double d = 1.123456789E27;
            System.Console.WriteLine(d);
        }
    }
}
