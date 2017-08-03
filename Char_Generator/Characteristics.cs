using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_Generator
{
    public class Characteristic
    {
        public string Name { get; set; }
        public string Aptitude { get; set; }
        public int Tier { get; set; }

        public Characteristic(string name, string aptitude)
        {
            Name = name;
            Aptitude = aptitude;
            Tier = 0;
        }

        public Characteristic(string name, string aptitude, int tier)
        {
            Name = name;
            Aptitude = aptitude;
            Tier = tier;
        }

    }
}
