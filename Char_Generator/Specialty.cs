namespace Char_Generator
{
	public class Specialty : modifiers
	{
		public string name { get; set; }

		public Specialty()
		{
		}
		public Specialty(string name)
		{
			this.name = name;
		}

		public override string ToString()
		{
			return string.Format("Specialty: " +
			                     "\nName: {0}\n" +
			                     "\tTalents:\n{1}\n" +
			                     "\tSkill:\n{2}\n" +
			                     "\tCharacteristics:\n{3}\n" +
			                     "\tAptitudes:\n{4}\n" +
			                     "\tSpecial Rules:\n{5}\n",
								 name,
								 talents,
								 skills.getDisplayed(),
								 characteristics.getDisplayed(),
								 aptitides,
								 getSpecialRules());
		}
	}
}
