using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapSolution
{
    public class Year
    {
        public static bool IsLeap(int year)
        {
            bool Result = false;

            if (year % 400 == 0)
            {
                Result = true;
            }
            else if (year % 100 == 0)
            {
                Result = false;
            }
            else if (year % 4 == 0)
            {
                Result = true;
            }

            return Result;
        }
    }
}
