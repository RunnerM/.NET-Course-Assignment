using System.Collections.Generic;

namespace Assignment_1.Models
{
    public class HairColor
    {
        private List<string> HairColors =new List<string>()
        {
            "blond","red","brown","black","white","grey","blue","green","leverpostej"
        };

        public bool checkHairColor(string hairColor)
        {
            hairColor=hairColor.ToLower();
            return HairColors.Contains(hairColor);
        }

        public void addHairColor(string hairColor)
        {
            hairColor = hairColor.ToLower();
            HairColors.Add(hairColor);
        }
    }
}