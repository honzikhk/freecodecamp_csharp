using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calc
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string gues = "";
            int guesCount = 0;
            int guesLimit = 3;
            bool outOfGuesses = false;

            while (gues != secretWord && !outOfGuesses) 
            {
                if (guesCount < guesLimit)
                {
                    Console.WriteLine("Enter gues: ");
                    gues = Console.ReadLine();
                    guesCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }

            Console.ReadLine();
        }


    }
}