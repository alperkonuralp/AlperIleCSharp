using System;

namespace Episode18
{
	class Program
	{
		static void Main(string[] args)
		{
			int index = 1;
			int toplam = 0;

			while(index <= 10)
			{
				toplam += index;
				index++;
			}

			Console.WriteLine("Toplam = " + toplam);





			toplam = 0;

			for(int i = 1; i <= 10; i++)
			{
				toplam += i;
			}


			Console.WriteLine("Toplam = " + toplam);



			toplam = 0;

			for (int i = 2; i <= 100; i += 2)
			{
				toplam += i;
			}


			Console.WriteLine("Toplam = " + toplam);


			toplam = 0;

			for (int i = 10; i > 0; i--)
			{
				toplam += i;
			}


			Console.WriteLine("Toplam = " + toplam);

		}
	}
}
