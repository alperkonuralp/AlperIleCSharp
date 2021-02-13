using System;

namespace EighthEpisode
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";

            int i = 5;

            string t = i.ToString();

            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine(t);
            Console.WriteLine(t + i);

            string u = s.Substring(0, 5);
            Console.WriteLine(u);

            int a = 5;
            int b = 6;

            string v = "a ve b sayılarının toplamı : " + (a + b);
            Console.WriteLine(v);

            string y = "a (" + a + ") ve b (" + b + ") sayılarının toplamı : " + (a + b);
            Console.WriteLine(y);

            string y1 = string.Format("a ({0}) ve b ({1}) sayılarının toplamı : {2}", a, b, a+b);
            Console.WriteLine(y1);

            string y2 = $"a ({a}) ve b ({b}) sayılarının toplamı : {a+b}";
            Console.WriteLine(y2);
        }
    }
}
