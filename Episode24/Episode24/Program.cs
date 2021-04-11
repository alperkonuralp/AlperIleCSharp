using System;

namespace Episode24
{
	class Program
	{
		private static int Topla(int a, int b, int c = 0, int d = 0)
		{
			return a + b + c + d;
		}

		private static int IslemYap(int deger, bool ekranaYaz = false)
		{
			int sonuc = deger * deger;
			if (ekranaYaz) Console.WriteLine("Sonuc = " + sonuc);
			return sonuc;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Topla(2, 3));
			Console.WriteLine(Topla(2, 3, 4));
			Console.WriteLine(Topla(2, 3, 4, 5));

			Console.WriteLine(IslemYap(5, true));
		}
	}
}
