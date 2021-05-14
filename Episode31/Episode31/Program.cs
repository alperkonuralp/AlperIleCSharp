using System;

namespace Episode31
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Kisi kisi = new Kisi();
			kisi.SetAd("Alper");
			kisi.SetSoyad("Konuralp");

			Kisi2 kisi2 = new Kisi2();
			//kisi2.Yas = 42;
			kisi2.Ad = "alper";//null;//"alper ali";
			kisi2.Soyad = "konuralp";

			Console.WriteLine($"{kisi2.Ad} {kisi2.Soyad}[{kisi2.Yas}]");
		}
	}
}
