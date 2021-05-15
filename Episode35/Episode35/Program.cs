using System;

namespace Episode35
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Calisan c1 = new Calisan();
			c1.Id = 1;
			c1.Ad = "Alper";
			c1.Soyad = "Konuralp";
			c1.SGKId = 12345;
			


			Kisi k1 = new Kisi();


			Musteri m1 = new Musteri();
			
		}
	}

	public class Kisi
	{
		public int Id { get; set; }

		public string Ad { get; set; }

		public string Soyad { get; set; }

	}

	public class Calisan : Kisi
	{
		public int SGKId { get; set; }
	}

	public class OtoCalisani : Calisan
	{

	}

	public class Musteri : Kisi
	{
		public DateTime AlisVerisTarihi { get; set; }
	}
}
