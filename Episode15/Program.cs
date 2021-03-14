using System;

namespace Episode15
{
	class Program
	{
		static void Main(string[] args)
		{
			// 0 dan 10 'a kadar olan sayıların toplamını bulmak istiyoruz.

			int toplam = 0;

			int index = 1;

			while (index <= 10)
			{
				// toplam += index++;
				toplam += index;
				index++;

				// toplam += ++index;
				// ++index;
				// toplam += index;
			}


			Console.WriteLine("index :" + index);
			Console.WriteLine("Toplam :" + toplam);


			string girilenDeger = "0";

			while(girilenDeger != "5")
			{
				Console.Write("Bir değer giriniz(Çıkış için 5): ");
				girilenDeger = Console.ReadLine();
			}

		}
	}
}
