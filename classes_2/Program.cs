using classes_2;
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
            Student student_1 = new Student("Jim", "Business", 2.8);
            Student student_2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student_1.HasHonors());
            Console.WriteLine(student_2.HasHonors());

            Console.ReadLine();
        }



    }
}