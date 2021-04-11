using System;

namespace Episode25
{
	class Program
	{
		private static int Topla(int a, int b, params int[] digerSayilar)
		{
			int toplam = a + b;
			foreach (int item in digerSayilar)
			{
				toplam += item;
			}

			return toplam;
		}


		static void Main(string[] args)
		{
			Console.WriteLine(Topla(2, 3));
			Console.WriteLine(Topla(2, 3, 4));
			Console.WriteLine(Topla(2, 3, 4, 5));
			Console.WriteLine(Topla(2, 3, 4, 5, 6));
			Console.WriteLine(Topla(2, 3, 4, 5, 6, 7, 8, 9, 10));
		}
	}
}
