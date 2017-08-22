using System.Collections.Generic;

namespace Char_Generator
{
	public class modifiers
	{
		public int wounds;
		public Skills skills = new Skills();
		public Talents talents = new Talents();
		public Attributes attributes = new Attributes();
		public Aptitudes aptitides = new Aptitudes();
		public List<string> specialRules = new List<string>();
	}
}
