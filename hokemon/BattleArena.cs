using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokemon
{
   class BattleArena
    {
        int attackValue = 0;
        int defenderHealth = 0;
        int round = 0;
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
                for (int i = 0; i<2;i++)
                {
                    attackValue = attacker.Attack_generator();

                    defenderHealth = defender.Health * defender.Defence_generator();

                    Console.WriteLine("{0} generated an attack of {1}", attacker.Name, attackValue);
                    Console.WriteLine("{0} generated a defense of {1}", defender.Name, defenderHealth);
                    defender.Health = defenderHealth - attackValue;
                }
                Console.WriteLine("turn has ended ad the roles will switch");
                temphoke = attacker;
                attacker = defender;
                defender = temphoke;
                }

        }
 
    }
}
