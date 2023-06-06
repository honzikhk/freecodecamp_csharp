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
            // return int = 2
            Console.WriteLine( 5 / 2 );
            // return decimal = 2,5
            Console.WriteLine(5 / 2.0);
            Console.WriteLine( Math.Abs(-10) );
            Console.WriteLine( Math.Pow(3, 2));
            Console.WriteLine( Math.Round(4.6));


            Console.ReadLine();
        }
    }
}