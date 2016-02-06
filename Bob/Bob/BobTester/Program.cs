using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobTester
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ValidYearInput = true;
            do
            {
                Console.Write("Enter input to test: ");
                string UserInput = Console.ReadLine();
                Console.WriteLine();
                if (ValidYearInput)
                {
                    Console.WriteLine("You: {0} Bob: {1}", UserInput, Bob.Bob.Hey(UserInput));
                }
            } while (ValidYearInput);
        }
    }
}
