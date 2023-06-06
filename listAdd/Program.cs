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
            // stupid adding integers to list a display process
            // declarate new empty list
            List<int> numbers = new List<int>();
            int counter = 0;
            for (int i = 0; i < 10; i++)

            {
                // to display right number, must add 1 to counter - 1. 2. 3. ...
                Console.WriteLine("write {0}. number to add: ", counter + 1);
                int user_input = Convert.ToInt16(Console.ReadLine());

                numbers.Add(user_input);
                Console.WriteLine("your array has now {0} elements.", numbers.Count);
                counter++;
            }



            Console.ReadLine();
        }
    }
}