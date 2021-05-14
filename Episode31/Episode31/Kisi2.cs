namespace Episode31
{
	public class Kisi2
	{
		private string ad = "Boş";
		private string soyad = "Boş";

		public string Ad
		{
			get
			{
				if (string.IsNullOrWhiteSpace(ad))
					return "Boş";
				if (Yas < 18)
					return ad[0] + ".";
				return ad;
			}
			set
			{
				if (!string.IsNullOrWhiteSpace(value))
					ad = char.ToUpper(value[0]) + value.Substring(1).ToLower();
				else
					ad = string.Empty;
			}
		}

		public string Soyad
		{
			get
			{
				if (string.IsNullOrWhiteSpace(soyad))
					return "Boş";
				if (Yas < 18)
					return soyad[0] + ".";
				return soyad;
			}
			set
			{
				soyad = value.ToUpper();
			}
		}

		public int Yas { get; set; } = 42;
	}
}
