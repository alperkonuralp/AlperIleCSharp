using System;

namespace Episode14
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			int tutulan = random.Next(0, 2);

			if(tutulan == 0)
				Console.WriteLine(tutulan + " Tura");
			else
				Console.WriteLine(tutulan + " Yazı");

			Console.WriteLine(tutulan + (tutulan == 0 
																		? " Tura" 
																		: " Yazı"));

			Console.WriteLine();

			tutulan = random.Next(0, 100);

			if (tutulan < 50)
				Console.WriteLine(tutulan + " Tura");
			else
				Console.WriteLine(tutulan + " Yazı");

			Console.WriteLine(tutulan + (tutulan < 50 ? " Tura" : " Yazı"));
		}
	}
}
