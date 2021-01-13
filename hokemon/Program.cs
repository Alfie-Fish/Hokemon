using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokemon
{
    class Program
    {
        /*public int int_generator(int minValue, int maxValue)
        {
            Random rnd = new Random();

            int randomValue;
            randomValue = rnd.Next(minValue, maxValue);

            return randomValue;
        }
        static void battle(int hokenumber1, int hokenumber2)
        {
            hoke0(hokenumber1).get_details();
        }*/
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
            Hokemon hoke03 = new Hokemon();

            Console.WriteLine("the name is {0}", hoke03.getname());

            hoke03.get_details();
            Console.ReadLine();
            Console.WriteLine("//////////////////////////////////////");
            Hokemon hoke04 = new Hokemon();

            Console.WriteLine("the name is {0}", hoke04.getname());

            hoke04.get_details();
            Console.ReadLine();

           /*int hokenum = int_generator(1, 4);
            int hokenum2 = int_generator(1, 4);
            battle(hokenum, hokenum2);*/
        }
    }
    }
