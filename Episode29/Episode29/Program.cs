using System;

namespace Episode29
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Araba araba = new Araba();

			araba.Renk = "Kırmızı";
			araba.KendiniTanit();
		}
	}

	public class Araba
	{
		public string Renk;

		public void KendiniTanit()
		{
			Console.WriteLine($"Ben bir {Renk} arabayım.");
		}
	}
}
