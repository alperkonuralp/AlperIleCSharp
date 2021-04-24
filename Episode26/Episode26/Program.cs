using System;

namespace Episode26
{
	class Program
	{
		private static int Topla(int a, int b)
		{
			return a + b;
		}

		private static int Hesapla(int[] veriler, out double ortalama)
		{
			int toplam = 0;
			foreach (int veri in veriler)
				toplam += veri;

			ortalama = ((double)toplam) / veriler.Length;
			return toplam;
		}

		static void Main(string[] args)
		{
			int[] dizi = new[] { 1, 2, 3, 4, 5, 6 };

			int sonuc = Hesapla(dizi, out double ortalama);

			Console.WriteLine($"Dizinin Toplamı : {sonuc}, ortalama : {ortalama}");

			Console.WriteLine("Lütfen bir sayı giriniz: ");
			string yazilan = Console.ReadLine();

			if (int.TryParse(yazilan, out int sayi))
				Console.WriteLine("Girdiğiniz Sayı : " + sayi);
			else
			{
				Console.WriteLine("Sayı girmediniz.");
			}
		}
	}
}
