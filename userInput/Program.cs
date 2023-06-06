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
            // writeline add new line, write does not
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            // same output, different way to reach it
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Hello " + name + "!");



            Console.ReadLine();
        }
    }
}