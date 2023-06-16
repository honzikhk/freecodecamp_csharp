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
            // two dimensional array
            int[,] numberGrid =
            {
                {1, 2 }, 
                {3, 4 },
                {5, 6 }
            };

            // more dimensions - 2columns, 3lines
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[1, 1]);

            Console.ReadLine();
        }
        
        


    }
}