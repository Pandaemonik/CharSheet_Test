namespace Char_Generator
{
	public class Characteristic
	{
		public string Name { set; get; }
		public string Secondary { set; get; }
		public int Tier { set; get; }
		public int Value { set; get; }

		public Characteristic(string name, string secondary, int tier, int value)
		{
			Name = name;
			Secondary = secondary;
			Tier = tier;
			Value = value;
		}

		public Characteristic()
		{
			Name = Secondary = "N/A";
			Tier = 0;
			Value = 0;
		}

		public Characteristic(string[] csvSplit)
		{
			Name = csvSplit[0].Trim();
			Secondary = csvSplit[1].Trim();
			Tier = int.Parse(csvSplit[2].Trim());
			Value = int.Parse(csvSplit[3].Trim());
		}

		public override string ToString()
		{
			return
				"Name: " + Name + "\n"
				+ "Aptitude: " + Secondary + "\n"
				+ "Tier: " + Tier + "\n"
				+ "Details: " + Value + "\n";
		}


	}
}
