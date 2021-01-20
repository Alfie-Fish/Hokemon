using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokemon
{
    class Halor : Hokemon //INHERITING from the Hokemon BASE CLASS
    {
        public string team = "halor";

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public void definition()
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        {
            Console.WriteLine("I am {0} , a member of the team halor", Name);
        }
    }
}