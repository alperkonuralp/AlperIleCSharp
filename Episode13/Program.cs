using System;

namespace Episode13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(new String('-', 30));
            System.Console.WriteLine("İşlemler");
            System.Console.WriteLine(new String('-', 30));
            System.Console.WriteLine("1. Toplama");
            System.Console.WriteLine("2. Çıkartma");
            System.Console.WriteLine("3. Çarpma");
            System.Console.WriteLine("4. Bölme");
            System.Console.WriteLine("Çıkış için ç");

            System.Console.Write("Seçiminiz : ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                case "-1":
                    Console.WriteLine("Toplam Seçtiniz.");
                    break;

                case "2":
                case "-2":
                    Console.WriteLine("Çıkartma Seçtiniz.");
                    break;

                case "3":
                case "-3":
                    Console.WriteLine("Çarpma Seçtiniz.");
                    break;

                case "4":
                    Console.WriteLine("Bölme Seçtiniz.");
                    break;

                case "c":
                case "C":
                case "ç":
                case "Ç":
                case "0":
                    Console.WriteLine("Çıkışı seçtiniz.");
                    break;

                default:
                    Console.WriteLine("Geçersiz Seçim");
                    break;
            }
        }
    }
}
