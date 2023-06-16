using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class MyClassBook
    {
        public string title;
        public string author;
        public int pages;


        // constructor. Called everytime when initialize this class. Has same name like a class
        public MyClassBook(string aTitle, string aAuthor, int aPages) {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        // if i add this empty constructor, i can create object without parameters
        public MyClassBook() 
        {
        }
    }
}
