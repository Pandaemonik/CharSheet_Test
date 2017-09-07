namespace Char_Generator
{
	public class Talent
	{
		public string Name { get; set; }
		public string Prerequisites { get; set; }
		public string primary { get; set; }
		public string secondary { get; set; }
		public string Benefit { get; set; }
		public string Details { get; set; }
		public int Tier { get; set; }
		public string Source { get; set; }

		public Talent()
		{
			Name = Prerequisites = primary = secondary = Benefit = Details = Source = "N/A";
			Tier = 1;
		}

		public Talent(string[] csvSplit)
		{
			Name = csvSplit[0].Trim();
			Prerequisites = csvSplit[1].Trim();
			primary = csvSplit[2].Trim();
			secondary = csvSplit[3].Trim();
			Benefit = csvSplit[4].Trim();
			Details = csvSplit[5].Trim();
			Tier = int.Parse(csvSplit[6].Trim());
			Source = csvSplit[7].Trim();
		}

		public override string ToString()
		{
			return
				"Name: " + Name + "\n"
				+ "Tier: " + Tier + "\n"
				+ "Source: " + Source + "\n"
				+ "Prerequisites: " + Prerequisites + "\n"
				+ "Aptitudes: " + primary + "  d - " + secondary + "\n"
				+ "Benefit: " + Benefit + "\n"
				+ "Details: " + Details + "\n";
		}

	}
}
