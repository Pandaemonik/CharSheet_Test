using System;
namespace Char_Generator
{
	public class Attribute
	{
		public string name { set; get; }
		public string secondary { set; get; }
		public int tier { set; get; }
		public int value { set; get; }

		public Attribute(string name, string secondary, int tier, int value)
		{
			this.name = name;
			this.secondary = secondary;
			this.tier = tier;
			this.value = value;
		}

		public Attribute()
		{
			name = secondary = "N/A";
			tier = 0;
			value = 0;
		}

		public Attribute(string[] csvSplit)
		{
			name = csvSplit[0].Trim();
			secondary = csvSplit[1].Trim();
			tier = int.Parse(csvSplit[2].Trim());
			value = int.Parse(csvSplit[3].Trim());
		}

		public override string ToString()
		{
			return
				"Name: " + name + "\n"
				+ "Aptitude: " + secondary + "\n"
				+ "Tier: " + tier + "\n"
				+ "Details: " + value + "\n";
		}
	}
}
