using System;

namespace Episode20
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] dizi = new[] { 32, 14, 8, 9, 14, 2, 0 };

			// While Örneği
			int indeks = 0;
			while (indeks < dizi.Length)
			{
				Console.WriteLine(dizi[indeks]);
				indeks++;
			}

			Console.WriteLine();

			// For Örneği
			for (int i = 0; i < dizi.Length; i++)
			{
				int item = dizi[i];
				Console.WriteLine(item);
			}


			Console.WriteLine();

			// Foreach Örneği
			int toplam = 0;
			foreach (int item in dizi)
			{
				Console.WriteLine(item);
				toplam += item;
			}

			Console.WriteLine("Toplam = " + toplam);
		}
	}
}
