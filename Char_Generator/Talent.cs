using System;

namespace Char_Generator
{
    public class Talent
    {

        public string Name { get; set; }
        public string Prerequisites { get; set; }
        public string Aptitude1 { get; set; }
        public string Aptitude2 { get; set; }
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
                Name = csvSplit[0];

                Prerequisites = csvSplit[1];
                Aptitude1 = csvSplit[2];
                Aptitude2 = csvSplit[3];
                Benefit = csvSplit[4];
                Details = csvSplit[5];
                Tier = csvSplit[6];
                Source = csvSplit[7];
            }

            else
            {
                Name = Prerequisites = Aptitude1 = Aptitude2 = Benefit = Details = "N/A";
            }
        }

        public Talent()
        {
            Name = Prerequisites = Aptitude1 = Aptitude2 = Benefit = Details = "N/A";
        }

        public override String ToString()
        {
            return
                "Name: " + Name + "\n"
                + "Tier: " + Tier + "\n"
                + "Prerequisites: " + Prerequisites + "\n"
                + "Aptitude 1: " + Aptitude1 + "\n"
                + "Aptitude 2: " + Aptitude2 + "\n"
                + "Benefit: " + Benefit + "\n"
                + "Details: " + Details + "\n"
                + "Source: " + Source + "\n";
        }

    }
}
