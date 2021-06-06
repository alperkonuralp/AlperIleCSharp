using System;

namespace Episode36
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Deneme deneme = new Deneme();
			
		}
	}

	public class Deneme
	{
		public int Id = 0;

		protected string ad = "";
	}

	public class Deneme2 : Deneme
	{
		public void A()
		{
			//this.ad
		}
	}
}
