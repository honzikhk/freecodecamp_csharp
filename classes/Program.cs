using classes;
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
            // first way
            /*
            MyClassBook book_1 = new MyClassBook();
            book_1.title = "Harry Potter";
            book_1.author = "JK Rowling";
            book_1.pages = 4000;

            MyClassBook book_2 = new MyClassBook();
            book_2.title = "Lord of the rings";
            book_2.author = "Tolkien";
            book_2.pages = 2;
            */

            //second way
            MyClassBook book_1 = new MyClassBook("Harry Potter", "JK Rowling", 500);

            // changing parameter
            book_1.pages = 423;

            Console.WriteLine(book_1.author);

            Console.ReadLine();
        }


    }
}