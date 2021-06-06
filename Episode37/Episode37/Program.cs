using System;

namespace Episode37
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Kisi kisi = new Kisi();

			Calisan calisan = new Calisan();
			Kisi calisanKisi = calisan; // new Calisan();
			Calisan calisan1 = (Calisan)calisanKisi;

			object calisanKisiObject = calisanKisi; // Boxing

			Calisan calisan2 = (Calisan)calisanKisiObject; // Unboxing

		}
	}

	public class Kisi
	{
		public int Id = 0;

		public string Ad = "";
	}

	public class Calisan : Kisi
	{
		public string SGKNo = "";
	}
}
