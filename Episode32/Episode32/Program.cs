using System;

namespace Episode32
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//Kisi kisi = new Kisi();
			//kisi.Ad = "Alper";
			//kisi.Soyad = "Konuralp";
			//Kisi kisi = new Kisi("Alper", "Konuralp");
			Kisi kisi = new Kisi(12, "Alper", "Konuralp");

			Console.WriteLine($"{kisi.Id} - {kisi.Ad} {kisi.Soyad}");
		}
	}

	public class Kisi
	{
		private static Random random = new Random();
		public Kisi()
		{
			Id = random.Next();
		}

		public Kisi(string ad, string soyad) : this()
		{
			Ad = ad;
			Soyad = soyad;
		}

		public Kisi(int id, string ad, string soyad) : this(ad, soyad)
		{
			Id = id;
		}


		public int Id { get; set; }

		public string Ad { get; set; } = "Boş";

		public string Soyad { get; set; } = "Boş";
	}
}
