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
            // declare array of integers
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};

            // declare empty array of 10 strings 
            string[] friends = new string[10];

            // print 1. element
            Console.WriteLine(luckyNumbers[0]);

            // update element
            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
}