using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter_setter
{
    internal class Movie
    {
        public string title;        //public can acces anyone
        public string director;
        private string rating;      //private cannot be accesed from outside. Only from this class. And with conditions. (see "set" method)    

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle; 
            director = aDirector;
            Rating = aRating;       //must be with capital R
        }

        public string Rating
        {  
            // getting the rating. just return value
            get { return rating; }
            // setting the rating but with condition
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
