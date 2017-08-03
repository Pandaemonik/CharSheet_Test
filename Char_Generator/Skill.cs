using System;
using System.Threading.Tasks;

namespace Char_Generator
{
    class Skill
    {
        public String Name { get; set; }
        public String Attribute { get; set; }
        public int Tier { get; set; }
		public enum Aptitude { agi,wepSkill,ballSkill};

        public Skill(String name, String attribute)
        {
            Name = name;
            Attribute = attribute;
            Tier = -1;
        }

        public Skill(String name, String attribute, int tier)
        {
            Name = name;
            Attribute = attribute;
            Tier = tier;
        }
    }
}
