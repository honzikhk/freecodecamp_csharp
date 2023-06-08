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

            SayHi("Mike", 20);
            Console.ReadLine();
        }

        // void means nothing return
        static void SayHi(string name, int age) 
        {
            Console.WriteLine($"Hello {name}, you are {age} years old");
        }

    }
}