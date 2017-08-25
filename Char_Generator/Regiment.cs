using System.Collections.Generic;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace Char_Generator
{
	public class Regiment : modifiers
	{
		public string homeworld { get; set; }
		public string commandingOfficer { get; set; }
		public string drawback { get; set; }
		public string name { get; set; }
		public List<string> doctrines = new List<string>();

		[JsonConstructor]
		public Regiment() { }

		public Regiment(Aptitudes aptitides, Characteristics characteristics, Talents talents, Skills skills)
		{
			homeworld = "N/A";
			commandingOfficer = "N/A";
			drawback = "N/A";
			name = "N/A";
			doctrines.Add("N/A");
			doctrines.Add("N/A");
			aptitides.Add("General");
			characteristics.Add(new Characteristic());
			characteristics.Add(new Characteristic());
			talents.Add(new Talent());
			talents.Add(new Talent());
			skills.Add(new Skill());
			skills.Add(new Skill());
		}

		public Regiment(string name)
		{
			this.name = name;
		}

		public string getDoctrines()
		{
			var toBeReturned = string.Empty;
			doctrines.ForEach(x => toBeReturned += x + ", ");
			return toBeReturned;
		}

		public override string ToString()
		{

			return string.Format("Regiment: \n" +
								 "Name: {0}\n" +
								 "Homeworld: {1},\n" +
								 "Commanding Officer: {2},\n" +
								 "Doctrines: {3},\n" +
								 "Drawback: {4},\n" +
								 "\tTalents:\n{5},\n" +
								 "\tSkills:\n{6}\n" +
								 "\tAttribures:\n{7}\n" +
								 "\tAptitudes:\n{8}\n" +
								 "\tSpecial Rules:\n{9}\n",
								 name,
								 homeworld,
								 commandingOfficer,
								 getDoctrines(),
								 drawback,
								 talents,
								 skills.getDisplayed(),
								 characteristics.getDisplayed(),
								 aptitides,
								 getSpecialRules()
								);
		}
	}
}
