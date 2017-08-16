using System;
namespace Char_Generator
{
	public class Attribute
	{
		public string name { set; get; }
		public string secondary { set; get; }
		public int tier { set; get; }
		public int value { set; get; }

		public Attribute(string name, string secondary, int tier, int value)
		{
			this.name = name;
			this.secondary = secondary;
			this.tier = tier;
			this.value = value;

		}

		public Attribute()
		{
			name = secondary = "N/A";
			tier = 0;
			value = 0;
		}
	}
}
