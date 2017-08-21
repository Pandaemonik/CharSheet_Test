
namespace Char_Generator
{
	public class Skill
	{
		public int Tier { get; set; }
		public string Name { get; set; }
		public string Primary { get; set; }
		public string Secondary { get; set; }
		public string Specialist { get; set; }

		public Skill(string name, string primary, string secondary, int tier)
		{
			Name = name;
			Primary = primary;
			Secondary = secondary;
			Tier = tier;
		}

		public Skill()
		{
			Name = Primary = Secondary = "N/A";
			Tier = -1;
		}

		public Skill(string[] csvSplit)
		{
			Name = csvSplit[0].Trim();
			Primary = csvSplit[1].Trim();
			Secondary = csvSplit[2].Trim();
			Tier = int.Parse(csvSplit[3].Trim());
			Specialist = csvSplit[4].Trim();
		}

		public override string ToString()
		{
			return
				"Name: " + Name + "\n"
				+ "Tier: " + Tier + "\n"
				+ "Aptitude 1: " + Primary + "\n"
				+ "Aptitude 2: " + Secondary + "\n"
				+ "Specialty: " + Specialist + "\n";
		}
	}
}
