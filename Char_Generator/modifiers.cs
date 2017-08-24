using System.Collections.Generic;

namespace Char_Generator
{
	public class modifiers
	{
		public int wounds;
		public Skills skills = new Skills();
		public Talents talents = new Talents();
		public Characteristics characteristics = new Characteristics();
		public Aptitudes aptitides = new Aptitudes();
		public List<string> specialRules = new List<string>();

		public virtual string getSpecialRules()
		{
			var toBeReturned = string.Empty;
			specialRules.ForEach(x => toBeReturned += x+"\n");
			return toBeReturned;
		}
	}
}
