using System;

namespace Episode22
{
	class Program
	{
		private static void BaslikYaz()
		{
			Console.WriteLine("Bölüm 22");
			Console.WriteLine(new string('-', 30));
		}

		private static void Topla(int a, int b)
		{
			Console.WriteLine($"a + b = {a} + {b} = {a+b}");
		}

		private static void Topla(int a, int b, int c)
		{
			Console.WriteLine($"a + b + c = {a} + {b} + {c} = {a + b + c}");
		}

		private static void Topla(float a, float b)
		{
			Console.WriteLine($"a + b = {a} + {b} = {a + b}");
		}

		private static void Islem(int a)
		{
			Console.WriteLine($" a * a = {a} * {a} = {a * a}");
			a += 10;
			Console.WriteLine($" a * a = {a} * {a} = {a * a}");
		}


		static void Main(string[] args)
		{
			BaslikYaz();

			Topla(2, 3);
			Topla(2, 3, 4);

			Topla(2.2f, 3.3f);


			Topla(a: 5, b: 8);
			Topla(b: 8, a: 5);

			int degisken = 5;
			Islem(degisken);
			Console.WriteLine(degisken);
		}
	}
}
