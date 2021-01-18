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
            
            Console.WriteLine("//////////////////////////////////////");
            Hokemon hoke02 = new Hokemon();
            Console.WriteLine("the name is {0}", hoke02.getname());

            hoke02.get_details();
            Console.WriteLine("//////////////////////////////////////");
            Hokemon hoke03 = new Hokemon();

            Console.WriteLine("the name is {0}", hoke03.getname());

            hoke03.get_details();
            
            Console.WriteLine("//////////////////////////////////////");
            Halor hoke04 = new Halor();

            Console.WriteLine("the name is {0}", hoke04.getname());

            hoke04.get_details();
            hoke04.definition();
            //Console.WriteLine("Team: {0}", hoke04.team);
            Console.WriteLine("//////////////////////////////////////");
            Console.ReadLine();

            BattleArena newbattleobject = new BattleArena();
            newbattleobject.requestAchallenger(hoke01);

            newbattleobject.theBattle(hoke01, hoke03);
        }
    }
    }
