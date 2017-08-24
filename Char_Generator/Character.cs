using System.Collections.Generic;
using Newtonsoft.Json;

namespace Char_Generator
{
	public class Character
	{
		public string regiment { get; set; }
		public string specialty { get; set; }
		public string name { get; set; }
		public string demeanour { get; set; }
		public string description { get; set; }
		public int wounds { get; set; }
		public int experienceSpent { get; set; }
		public int experienceLeft { get; set; }
		public List<string> specialRules { get; set; }
		public Attributes attributes { get; set; }
		public Skills skills { get; set; }
		public Talents talents { get; set; }
		public Aptitudes aptitudes { get; set; }

		public Character()
		{
			aptitudes = new Aptitudes("General");
			skills = new Skills("TextFiles\\Skills_CSV.csv");
			attributes = new Attributes("TextFiles\\Attributes_CSV.csv");
			talents = new Talents("TextFiles\\Talents_CSV.csv");
			experienceSpent = 0;
			experienceLeft = 0;
		}

		[JsonConstructor]
		public Character(Attributes attributes, Skills skills, Talents talents, Aptitudes aptitudes, string campaignId)
		{
			this.attributes = attributes;
			this.skills = skills;
			this.talents = talents;
			this.aptitudes = aptitudes;
		}

		public string getSpecialRules()
		{
			string toBeReturned = string.Empty;
			foreach (string specialRule in specialRules)
			{
				toBeReturned += specialRule + "\n";
			}
			return toBeReturned;
		}

		public int checkAptitudesCount(string primary, string secondary)
		{
			primary = primary.Trim();
			secondary = secondary.Trim();
			if (aptitudes.checkPossesed(primary) && aptitudes.checkPossesed(secondary))
			{
				return 2;
			}
			if (aptitudes.checkPossesed(primary) || aptitudes.checkPossesed(secondary))
			{
				return 1;
			}
			return 0;
		}

		public override string ToString()
		{
			return string.Format(
				"Character:" +
				"\n\t Name\n{0}" +
				"\n\t Regiment\n{1}" +
				"\n\t Specialty\n{2}" +
				"\n\t Demeanour\n{3}" +
				"\n\t Description\n{4}" +
				"\n\t Wounds\n{5}" +
				"\n\t ExperienceSpent\n{6}" +
				"\n\t ExperienceLeft\n{7}" +
				"\n\t Attributes\n{8}" +
				"\n\t Aptitudes\n{9}" +
				"\n\t SpecialRules\n{10}" +
				"\n\t Talents\n{11}",
				name,
				regiment,
				specialty,
				demeanour,
				description,
				wounds,
				experienceSpent,
				experienceLeft,
				attributes,
				skills,
				aptitudes,
				getSpecialRules(),
				talents
			);
		}
	}
}
