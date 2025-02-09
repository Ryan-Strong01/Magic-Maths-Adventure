using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Maths_Adventure.Classes
{
    public static class Validation
    {
        public static void Presence(string ThingChecked, string input,List<string> errors, out bool isPresent)//out variable so I can check whether it passes the validation check
        {
         
            if (!string.IsNullOrWhiteSpace(input))
            {
                isPresent = true;
            }
            else
            {
                errors.Add("Nothing has been entered for " + ThingChecked);
                isPresent = false;
            }
        }

        public static void Length(string ThingChecked, string input, List<string> errors, out bool isLength)
        {
            if (input.Length > 5)
            {
                isLength = true;
            }
            else
            {
                errors.Add(ThingChecked + " must be greater than 5 characters and less than 50");
                isLength = false;
            }
        }

        public static void Range(string ThingChecked, string input, List<string> errors, out bool isRange)
        {
            if(input.Length > 1 && input.Length < 50)
            {
                isRange = true;
            }
            else
            {
                errors.Add(ThingChecked + " must be inbetween 1 and 50 characters");
                isRange = false;
            }
        }

        public static void Format(string ThingChecked, string input, List<string> errors, out bool isFormat)
        {
            string Last2Char = input.Substring(input.Length - 2);
            int result;
            if (int.TryParse(Last2Char, out result))//parsing it to see if the variable can be converted into integers (ie if its actually a number)
            {
                isFormat = true;
            }
            else
            {
                errors.Add(ThingChecked + " does not contain 2 numbers at the end");
                isFormat = false;
            }
        }
    }
}
