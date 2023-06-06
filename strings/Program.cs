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
            string myPhrase = "Girrafe Academy";

            // every alement low; ToUpper...
            Console.WriteLine(myPhrase.ToLower());
            // true or false if contain the string or not
            Console.WriteLine(myPhrase.Contains("Gir"));
            // clasic indexing
            Console.WriteLine(myPhrase[2]);
            // index where the string stars, or in case one letter where it is
            // if not found = -1
            Console.WriteLine(myPhrase.IndexOf("Academy"));
            // spliting; only index = start slicing to end; 8,10 = start,end cutting
            Console.WriteLine(myPhrase.Substring(8));

            Console.ReadLine();
        }
    }
}