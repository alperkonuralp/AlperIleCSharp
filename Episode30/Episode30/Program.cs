using System;

namespace Episode30
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Araba araba = new Araba();
			araba.RengiDegistir("Siyah");
			Console.WriteLine(araba.RengiSoyle());
		}
	}
}
