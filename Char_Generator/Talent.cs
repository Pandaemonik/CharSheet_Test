using System;

namespace Char_Generator
{
    public class Talent
    {

        public string Name { get; set; }
        public string Prerequisites { get; set; }
        public string primary { get; set; }
        public string secondary { get; set; }
        public string Benefit { get; set; }
        public string Details { get; set; }
        public string Tier { get; set; }
        public string Source { get; set; }

        public Talent(String csvLineRead)
        {
            String[] csvSplit = csvLineRead.Split('|');
            if (csvSplit[0] != null || csvSplit[1] != null || csvSplit[2] != null || csvSplit[3] != null || csvSplit[4] != null ||
                csvSplit[5] != null || csvSplit[6] != null || csvSplit[7] != null)
            {
				//TODO: Move this to container class
                Name = csvSplit[0];

                Prerequisites = csvSplit[1];
                primary = csvSplit[2];
                secondary = csvSplit[3];
                Benefit = csvSplit[4];
                Details = csvSplit[5];
                Tier = csvSplit[6];
                Source = csvSplit[7];
            }

            else
            {
                Name = Prerequisites = primary = secondary = Benefit = Details = "N/A";
            }
        }

        public Talent()
        {
            Name = Prerequisites = primary = secondary = Benefit = Details = "N/A";
        }

        public override String ToString()
        {
            return
                "Name: " + Name + "\n"
                + "Tier: " + Tier + "\n"
                + "Prerequisites: " + Prerequisites + "\n"
                + "Aptitude 1: " + primary + "\n"
                + "Aptitude 2: " + secondary + "\n"
                + "Benefit: " + Benefit + "\n"
                + "Details: " + Details + "\n"
                + "Source: " + Source + "\n";
        }

    }
}
