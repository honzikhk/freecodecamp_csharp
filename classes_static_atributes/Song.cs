using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_static_atributes
{
    class Song
    {
        //normal atributes
        // each object have their own atribute (unique)
        public string title;
        public string artist;
        public int duration;

        //static variable (atribute)
        //belongs to the class, not object
        //its info about class, not object
        public static int songCount = 0;

        // constructor. call every time when object is created
        public Song(string aTitle, string aArtist, int aDuration) 
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
        //with this method i can acces the songCount atribute by object
        public int getSongCount()
        {
            return songCount;
        }
    }
}
