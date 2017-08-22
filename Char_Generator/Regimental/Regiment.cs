using System.Collections.Generic;

namespace Char_Generator
{
	public class Regiment : modifiers
	{
		public int points { get; set; }
		public string homeworld { get; set; }
		public string commandingOfficer { get; set; }
		public List<string> doctrines { get; set; }
		public string drawback { get; set; }

		public string name = string.Empty;

		public Regiment() { }

		public Regiment(string name)
		{
			this.name = name;
		}
		public void SerializeJson()
		{ }
	}
}
