using System;

namespace Episode19
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1;
			int b = 2;
			int c = 3;

			int toplam = a + b + c;

			Console.WriteLine("Toplam = " + toplam);

			Console.WriteLine("Sınıf Kaç Kişi : ");
			int sinifMevcudu = int.Parse(Console.ReadLine());

			int[] ogrenciYaslari = new int[sinifMevcudu];

			for(int i = 0; i < sinifMevcudu; i++)
			{
				Console.WriteLine($"{i+1}. Öğrencinin Yaşı : ");
				int yas = int.Parse(Console.ReadLine());
				ogrenciYaslari[i] = yas;
			}


			toplam = 0;
			for (int i = 0; i < sinifMevcudu; i++)
			{
				toplam += ogrenciYaslari[i];
			}

			int ortalama = toplam / sinifMevcudu;
			Console.WriteLine("Ortalama Yaş = " + ortalama);

		}
	}
}
