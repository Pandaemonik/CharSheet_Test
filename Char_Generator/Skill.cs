
namespace Char_Generator
{
	public class Skill
	{
		public int tier { get; set; }
		public string name { get; set; }
		public string primary { get; set; }
		public string secondary { get; set; }
		public string specialist { get; set; }

		public Skill(string name, string primary, string secondary, int tier)
		{
			this.name = name;
			this.primary = primary;
			this.secondary = secondary;
			this.tier = tier;
		}

		public Skill()
		{
			name = primary = secondary = "N/A";
			tier = -1;
		}

		public Skill(string[] csvSplit)
		{
			name = csvSplit[0].Trim();
			primary = csvSplit[1].Trim();
			secondary = csvSplit[2].Trim();
			tier = int.Parse(csvSplit[3].Trim());
			specialist = csvSplit[4].Trim();
		}

		public override string ToString()
		{
			return
				"Name: " + name + "\n"
				+ "Tier: " + tier + "\n"
				+ "Aptitude 1: " + primary + "\n"
				+ "Aptitude 2: " + secondary + "\n"
				+ "Specialty: " + specialist + "\n";
		}
	}
}
