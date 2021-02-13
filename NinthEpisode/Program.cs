using System;

namespace NinthEpisode
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "a " + " b";
            string b = $"Bu bir denemedir ( {a} )";
            string c = $"int min = {int.MinValue} , max = {int.MaxValue} )";

            string d = b.Substring(0, 6);
            System.Console.WriteLine(d);

            string e = b.Substring(7, 9);
            System.Console.WriteLine(e);

            int f = b.IndexOf("bir");
            System.Console.WriteLine(f);

            int g = b.IndexOf("Bir");
            System.Console.WriteLine(g);

            bool h = b.Contains("bir");
            System.Console.WriteLine(h);

            char i = b[5];
            System.Console.WriteLine(i);
        }
    }
}
