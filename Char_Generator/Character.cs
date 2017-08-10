using System;
namespace Char_Generator
{
	public class Character
	{
		public Attributes attributes { get; set; }
		public Skills skills { get; set; }
		public Talents talents { get; set; }
		public int experience { get; set; }
		public string campaignId { get; set; }

		public Character()
		{
			attributes = null;
			skills = null;
			talents = null;
			experience = 0;
			campaignId = null;
		}
	}
}
