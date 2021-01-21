using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokemon
{
   class BattleArena
    {
        
        int round = 1;
        Hokemon temphoke;
        public void requestAchallenger(Hokemon requestor)
        {
            Console.WriteLine("{0}: wants a challenger", requestor.getname());
        }
        public void theBattle(Hokemon attacker, Hokemon defender)
        {
            Console.WriteLine("{0}; is waiting ..........", attacker.getname());
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0}; is waiting ..........", attacker.getname());
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0} has accepted the challenge", defender.getname());

            while(Convert.ToInt32(defender.Health) > 0 && Convert.ToInt32(attacker.Health) > 0)
                {
                Console.WriteLine("round: {0}", round);
                int attackValue = 0;
                int defenceValue = 0;
                for (int i = 1; i<2;i++)
                {
                    attackValue = attacker.Attack_generator();

                    defenceValue= defender.Defence_generator();

                    Console.WriteLine("{0} generated an attack of {1}", attacker.Name, attackValue);
                    Console.WriteLine("{0} generated a defense of {1}", defender.Name, defenceValue);
                    if ((attackValue - defenceValue) >0)
                    {
                        defender.Health = defender.Health - (attackValue - defenceValue);
                    }
                    Console.WriteLine("{0} has {1} health remaning \n{2} has {3} health remaining",attacker.Name , attacker.Health, defender.Name, defender.Health);
                    System.Threading.Thread.Sleep(2000);
                }
                round = round + 1;
                Console.WriteLine("turn has ended ad the roles will switch");
                temphoke = attacker;
                attacker = defender;
                defender = temphoke;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("press enter to proceed to round {0}", round);
                Console.ReadLine();

            }

        }
 
    }
}
