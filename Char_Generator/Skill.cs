using System;
using System.Threading.Tasks;

namespace Char_Generator
{
	public class Skill
	{
		string v;

		public int tier { get; set; }
		public String name { get; set; }
		public Aptitude primary { get; set; }
		public Aptitude secondary { get; set; }
		public Attribute attribute { get; set; }

		public Skill(String name, Aptitude primary, Aptitude secondary, Attribute attribute, int tier)
		{
			this.name = name;
			this.primary = primary;
			this.secondary = secondary;
			this.attribute = attribute;
			this.tier = tier;
		}

		public Skill()
		{
			name = "N/A";
			primary = Aptitude.general;
			secondary = Aptitude.agility;
			tier = -1;
			attribute = new Attribute();
		}

		public Skill(string csvLineRead)
		{
			String[] csvSplit = csvLineRead.Split('|');
			if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null || csvSplit[4] != null ||
				csvSplit[5] != null || csvSplit[6] != null || csvSplit[7] != null)
			{
				Name = csvSplit[0];

				Prerequisites = csvSplit[1];
				Aptitude1 = csvSplit[2];
				Aptitude2 = csvSplit[3];
				Benefit = csvSplit[4];
				Details = csvSplit[5];
				Tier = csvSplit[6];
				Source = csvSplit[7];
			}

			else
			{
				Name = Prerequisites = Aptitude1 = Aptitude2 = Benefit = Details = "N/A";
			}
		}
	}
}
