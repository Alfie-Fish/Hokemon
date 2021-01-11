using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to hokeworld home of the hokemon");

                //instantiating a new object
            Hokemon hoke01 = new Hokemon();

            Console.WriteLine("the name is {0}",hoke01.getname());

            hoke01.get_details();
            Console.ReadLine();
            Console.WriteLine("//////////////////////////////////////");
            Hokemon hoke02 = new Hokemon();

            Console.WriteLine("the name is {0}", hoke02.getname());

            hoke02.get_details();
            Console.ReadLine();
        }
    }
}
