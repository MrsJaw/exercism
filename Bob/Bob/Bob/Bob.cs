using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bob
{
    public class Bob
    {
        public static string Hey(string userInput)
        {
            string Result = "Whatever.";
            string FormattedUserInput = userInput.Trim();

            if (!string.IsNullOrWhiteSpace(FormattedUserInput))
            {
                //Bob answers 'Sure.' if you ask him a question.
                if (FormattedUserInput.EndsWith("?"))
                {
                    Result = "Sure.";
                }
                //He answers 'Whoa, chill out!' if you yell at him.
                Regex FindCapitalAlphabetical = new Regex("[A-Z]+");
                if (FormattedUserInput.Equals(FormattedUserInput.ToUpper()) && FindCapitalAlphabetical.IsMatch(FormattedUserInput))
                {
                    Result = "Whoa, chill out!";
                }                
            }
            else
            {
                //He says 'Fine. Be that way!' if you address him without actually saying anything.
                Result = "Fine. Be that way!";
            }
           
            //He answers 'Whatever.' to anything else.
            return Result;
           
        }
    }
}
