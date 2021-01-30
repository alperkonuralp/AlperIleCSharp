using System;

namespace ThirdEpisode
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = 12;

            // Console.WriteLine($"int [{int.MinValue}, {int.MaxValue}] arasında bir değer tutabilir.");

            // byte  - 1 byte
            // short - 2 byte
            // int   - 4 byte
            // long  - 8 byte
            byte b = 1;
            short s = 2;
            int i = 4;
            long l = 8;

            Console.WriteLine($"byte  [{byte.MinValue}, {byte.MaxValue}] arasında bir değer tutabilir. b = {b}");
            Console.WriteLine($"short [{short.MinValue}, {short.MaxValue}] arasında bir değer tutabilir. s = {s}");
            Console.WriteLine($"int   [{int.MinValue}, {int.MaxValue}] arasında bir değer tutabilir. i = {i}");
            Console.WriteLine($"long  [{long.MinValue}, {long.MaxValue}] arasında bir değer tutabilir. l = {l}");
            
            byte c = 129;
            byte d = 200;
            byte e = (byte)(c + d);
            Console.WriteLine(e);

            short f = 129;
            short g = 200;
            short h =(short)(f + g);
            Console.WriteLine(h);

            short j = c;
            byte k = (byte)f;


            int m = (int)l;
            short n = (short)l;
            byte o = (byte)l;
        }
    }
}
