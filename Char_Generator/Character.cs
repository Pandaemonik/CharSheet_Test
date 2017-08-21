using Newtonsoft.Json;

namespace Char_Generator
{
	public class Character
	{
		public Attributes attributes { get; set; }
		public Skills skills { get; set; }
		public Talents talents { get; set; }
		public Aptitudes aptitudes { get; set; }
		public int experience { get; set; }
		public string campaignId { get; set; }


		public Character()
		{
			aptitudes = new Aptitudes("General");
			skills = new Skills("TextFiles\\Skills_CSV.csv");
			attributes = new Attributes("TextFiles\\Attributes_CSV.csv");
			talents = new Talents("TextFiles\\Talents_CSV.csv");
			experience = 0;
			campaignId = "RFF_ID_1";
		}

		[JsonConstructor]
		public Character(Attributes attributes, Skills skills, Talents talents, Aptitudes aptitudes , int experience, string campaignId)
		{
			this.attributes = attributes;
			this.skills = skills;
			this.talents = talents;
			this.aptitudes = aptitudes;
			this.experience = experience;
			this.campaignId = campaignId;
		}

		public override string ToString()
		{
			return string.Format("Character:\n\tAttributes\n{0} \n\tSkills\n{1} \n\tTalents\n{2} \n\tAptitudes\n{3}\n\texperience\n{4}, \n\tcampaignId\n{5}", attributes, skills, talents, aptitudes, experience, campaignId);
		}

		public string SerializeJSON()
		{
			var json = JsonConvert.SerializeObject(this, Formatting.Indented);
			return json;
		}
	}
}
