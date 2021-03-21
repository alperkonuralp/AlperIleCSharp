using System;

namespace Episode17
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1;

			while(a < 10)
			{
				Console.WriteLine(a);
				a++;
			}

			Console.WriteLine();

			a = 1;

			do
			{
				Console.WriteLine(a);
				a++;
			} while (a < 10);
		}
	}
}
