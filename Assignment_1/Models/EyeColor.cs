using System.Collections.Generic;

namespace Assignment_1.Models
{
    public class EyeColor
    {
        private List<string> EyeColors= new List<string>()
        {
            "black","brown","grey","green","blue","amber","hazel"
        };

        public bool checkEyeColor(string eyeColor)
        {
            eyeColor = eyeColor.ToLower();
            return EyeColors.Contains(eyeColor);
        }

        public void addColor(string eyeColor)
        {
            eyeColor = eyeColor.ToLower();
            EyeColors.Add(eyeColor);
        }
        
    }
}