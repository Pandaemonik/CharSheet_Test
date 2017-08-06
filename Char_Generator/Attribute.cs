using System;
namespace Char_Generator
{
	public class Attribute
	{
		public Aptitude name { set; get; }
		public Aptitude secondary { set; get; }
		public int tier { set; get; }
		public int value { set; get; }

		public Attribute(Aptitude name, Aptitude secondary, int tier, int value)
		{
			this.name = name;
			this.secondary = secondary;
			this.tier = tier;
			this.value = value;

		}

		public Attribute()
		{
			name = Aptitude.general;
			secondary = Aptitude.agility;
			tier = 0;
			value = 0;
		}
	}
}
