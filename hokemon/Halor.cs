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

        public void definition()
        {
            Console.WriteLine("I am {0} , a member of the team halor", Name);
        }
    }
