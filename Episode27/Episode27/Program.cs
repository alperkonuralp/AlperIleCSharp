using System;

namespace Episode27
{
	class Program
	{
		private static int Topla(ref int a, int b)
		{
			int toplam = a + b;
			a++;
			b++;
			return toplam;
		}

		static void Main(string[] args)
		{
			int a = 3;
			int b = 5;

			int toplam = Topla(ref a, b);

			Console.WriteLine($"a + b = {a} + {b} = {toplam}");

		}
	}
}
