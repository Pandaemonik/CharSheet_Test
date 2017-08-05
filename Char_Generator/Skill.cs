using System;
using System.Threading.Tasks;

namespace Char_Generator
{
    class Skill
    {
        public int tier { get; set; }
		public String name { get; set; }
		public Aptitude primary { get; set; }
		public Aptitude secondary { get; set; }
		public Attribute attribute { get; set; }
		
        public Skill(String name, Aptitude primary, Aptitude secondary, Attribute attribute, int tier)
        {
            this.name = name;
			this.primary = primary;
			this.secondary = secondary;
            this.attribute = attribute;
            this.tier = tier;
        }

        public Skill()
        {
			name = "N/A";
			primary = Aptitude.general;
			secondary = Aptitude.agility;
			tier = -1;
			attribute = new Attribute();
		}
    }
}
