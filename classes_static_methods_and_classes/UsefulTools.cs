using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_static_methods_and_classes
{
    // with static keyword the class is being static. Cannot create instance of this class now. Must acces method directly, without creating object
    static class UsefulTools
    {
        // static method belongs to class
        public static void SayHi(string name) 
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
