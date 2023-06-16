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
            try
            {
                Console.Write("Write first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Write second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                var result = firstNumber / secondNumber;

                Console.WriteLine($"Result of {firstNumber} / {secondNumber} is {result}");
            }
            /*

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            //always executed
            finally
            {

            }

            

            Console.ReadLine();
        }
        


    }
}