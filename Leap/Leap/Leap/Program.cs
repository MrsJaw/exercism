using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year = 0;
            bool ValidYearInput = true;
            do
            {
                Console.Write("Enter a year to test: ");
                string UserInput = Console.ReadLine();
                ValidYearInput = int.TryParse(UserInput, out Year);
                Console.WriteLine();
                if(ValidYearInput)
                {
                    Console.WriteLine("{0} {1} a leap year.", Year.ToString(), LeapSolution.Year.IsLeap(Year) ? "was" : "was not");
                }
            } while (ValidYearInput);
        }
    }
}
