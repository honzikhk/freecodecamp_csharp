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
            Console.WriteLine(Cube(5));
            Console.ReadLine();
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}