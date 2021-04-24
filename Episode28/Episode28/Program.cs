using System;

namespace Episode28
{
	class Program
	{
		private static int Topla(int a, int b)
		{
			return a + b;
		}
		

		private static int Topla(int a, ref int b)
		{
			return a + b;
		}


		private static double Topla(double a, double b)
		{
			return a + b;
		}


		static void Main(string[] args)
		{
			int b = 3;
			Console.WriteLine(Topla(2,ref b));

			Console.WriteLine("Hello World!");
		}
	}
}
