using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_inheritance
{
    //italian chef inheritate all from chef 
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Making pasta");
        }
        // in subclass must be keyword "override" if i want to overwrite the method from superclass
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }
    }
    
}
