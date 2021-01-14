using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokemon
{
    class BattleArena
    {
        public void requestAchallenger(Hokemon requestor)
        {
            Console.WriteLine("{0}: wants a challenger", requestor.getname());
        }
        public void theBattle(Hokemon attacker , Hokemon defender)
        {
            Console.WriteLine("{0}; is waiting ..........", attacker.getname());
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0}; is waiting ..........", attacker.getname());
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0} has accepted the challenge", defender.getname());
        }
    }
}
