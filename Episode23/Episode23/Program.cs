using System;

namespace Episode23
{
	internal class Program
	{
		private static int Topla(int a, int b)
		{
			return a + b;
		}

		private static string YasMesaji(int yas)
		{
			if (yas < 4) return "Bebek";
			else if (yas < 16) return "Çocuk";
			else if (yas < 30) return "Genç";
			else if (yas < 50) return "Orta Yaşlı";
			else if (yas < 80) return "Yaşlı";
			return "Çok yaşlı";
		}

		private static string YasMesaji2(int yas)
		{
			string mesaj = "Çok yaşlı";
			if (yas < 4) mesaj = "Bebek";
			else if (yas < 16) mesaj = "Çocuk";
			else if (yas < 30) mesaj = "Genç";
			else if (yas < 50) mesaj = "Orta Yaşlı";
			else if (yas < 80) mesaj = "Yaşlı";
			return mesaj;
		}

		private static void Main(string[] args)
		{
			int ilkDeger = 2;
			int ikinciDeger = 3;

			int sonuc = Topla(ilkDeger, ikinciDeger);
			Console.WriteLine($"a + b = {ilkDeger} + {ikinciDeger} = {sonuc}");

			Console.WriteLine("Yaşınız Kaç : ");
			int yas = int.Parse(Console.ReadLine());

			Console.WriteLine(YasMesaji(yas));
			Console.WriteLine(YasMesaji2(yas));
		}
	}
}