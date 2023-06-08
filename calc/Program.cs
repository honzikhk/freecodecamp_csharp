using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calc
    {
        static void Main(string[] args)
        {
            // simple calulator +;-;*;//
            Console.Write("Write first number: ");
            double number_1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Write second number: ");
            double number_2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose operation ( + | - | * | / ): ");
            var operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine("You choose adding, so {0} {1} {2} = {3}", number_1, operation, number_2, number_1 + number_2);
            }
            else if (operation == "-")
            {
                Console.WriteLine("You choose subtraction, so {0} {1} {2} = {3}", number_1, operation, number_2, number_1 - number_2);
            }
            else if (operation == "*")
            {
                Console.WriteLine("You choose multiplication, so {0} {1} {2} = {3}", number_1, operation, number_2, number_1 * number_2);
            }
            else if (operation == "/")
            { 
                Console.WriteLine("You choose division, so {0} {1} {2} = {3}", number_1, operation, number_2, number_1 / number_2);
            Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You entered a invalid operator");
            }
        }
    }
}