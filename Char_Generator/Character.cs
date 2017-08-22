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
		public string campaignId { get; set; }

		public Character()
		{
			aptitudes = new Aptitudes("General");
			skills = new Skills("TextFiles\\Skills_CSV.csv");
			attributes = new Attributes("TextFiles\\Attributes_CSV.csv");
			talents = new Talents("TextFiles\\Talents_CSV.csv");
			experienceSpent = 0;
			experienceLeft = 0;
			campaignId = "RFF_ID_1";
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

		public override string ToString()
		{
			return string.Format("Character:\n\tAttributes\n{0}" +
								 "\n\tSkills\n{1} \n\tTalents\n{2}" +
								 "\n\tAptitudes\n{3}" +
								 "\n\texperienceLeft\n{4}," +
								 "\n\tcampaignId\n{5}",
								 attributes,
								 skills,
								 talents,
								 aptitudes,
								 experienceLeft,
								 campaignId);
		}
	}
}
