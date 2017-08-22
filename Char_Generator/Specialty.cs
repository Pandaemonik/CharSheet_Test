namespace Char_Generator
{
	public class Specialty:modifiers
	{
		public string name { get; set; }

		public Specialty(){ }
		public Specialty(string name)
		{
			this.name = name;
		}
	}
}
