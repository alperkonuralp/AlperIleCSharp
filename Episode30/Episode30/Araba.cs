using System;
using System.Collections.Generic;
using System.Text;

namespace Episode30
{
	public class Araba
	{
		private string renk;

		public string RengiSoyle()
		{
			return renk;
		}

		public void RengiDegistir(string r)
		{
			switch (r)
			{
				case "Beyaz":
				case "Siyah":
				case "Metalik":
					renk = r;
					break;
				default:
					throw new ApplicationException("Renk Tanımsız.");
			}
		}
	}

	public class BinekAraba : Araba
	{

	}
}
