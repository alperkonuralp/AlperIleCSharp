using System;

namespace Episode16
{
	class Program
	{
		static void Main(string[] args)
		{
			int toplam = 0, indeks = 0;

			while (indeks < 10)
			{
				indeks++;
				if (indeks == 5) continue;

				toplam += indeks;
				if (toplam >= 35) break;
			}

			Console.WriteLine($"Indeks = {indeks}");
			Console.WriteLine($"Toplam = {toplam}");
		}
	}
}
