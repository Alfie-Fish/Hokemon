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
            //declaring the veriables
            Hokemon[] ChallengerArray = new Hokemon[3]; //creates an array of 3 hokemon 
            BattleArena newBattleObject = new BattleArena();

            Hokemon temp;
            Random rnd = new Random();
            Boolean repeatGame = true;
            String Result;

            Console.WriteLine("Welcome to Hokeworld, home of the Hokemon");

            Halor player = new Halor();

            for (int i = 0; i < 3; i++)
            {
                ChallengerArray[i] = new Hokemon();
            }
            while (repeatGame == true)
            {
                Console.WriteLine("{0} extended a challenger for a battle.", player.Name);

                temp = ChallengerArray[rnd.Next(0, ChallengerArray.Length)];
                if ((temp.Health) > 0)
                {

                    if ((player.Health) > 0)
                    {
                        //player.get_details();
                        //temp.get_details();
                        newBattleObject.theBattle(player, temp);
                    }
                    else
                    {
                        Console.WriteLine("{0} Does not have enough health to battle.", player.Name);

                    }
                }
                else
                {
                    Console.WriteLine("{0} Does not have enough health to battle.", temp.Name);
                }
                if ((player.Health) > 0)
                {
                    Console.WriteLine("Do you want annother battle?");
                    Result = Console.ReadLine();
                    if ((Result.ToLower())[0] == 'n')
                    {
                        repeatGame = false;
                    }
                }
                else
                {
                    Console.WriteLine("{0} has taken too much damage and cannot battle again", player.Name);
                    repeatGame = false;
                }
            }
            Console.ReadLine();
                /* Console.WriteLine("welcome to hokeworld home of the hokemon");
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

                 newbattleobject.theBattle(hoke01, hoke02);
                 //Console.WriteLine("{0} has defeated {1} and won the battle", Winner, Loser);
                 Console.ReadLine();*/
            
        }
    }
}