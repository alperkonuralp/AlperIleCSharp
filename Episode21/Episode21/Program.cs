using System;

namespace Episode21
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i = 4;
			int j = 7;
			string yazi = "Merhaba";

			string merhabaDunya = SayilariTopla(i);

			Console.WriteLine(merhabaDunya);
		}

		public static string SayilariTopla(int ii)
		{
			Console.WriteLine(ii);
			Console.WriteLine("SayilariTopla Metodu Çağırıldı.");
			string md = "Merhaba Dünya!...";

			return md;
		}
	}
}
