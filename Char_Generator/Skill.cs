using System;
using System.Windows.Forms;

namespace Char_Generator
{
	public class Skill
	{
		public int tier { get; set; }
		public string name { get; set; }
		public string primary { get; set; }
		public string secondary { get; set; }
		public string specialist { get; set; }

		public Skill(String name, string primary, string secondary, Attribute attribute, int tier)
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
			//attribute = new Attribute();
		}

		public Skill(string[] csvSplit)
		{
			name = csvSplit[0].Trim();
			primary = csvSplit[1].Trim();
			secondary = csvSplit[2].Trim();
			tier = Int32.Parse(csvSplit[3].Trim());
			specialist = csvSplit[4].Trim();
			//attribute = csvSplit[4];
		}

		public override String ToString()
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
