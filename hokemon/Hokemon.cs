using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hokemon
{
    class Hokemon
    {
        //hokemon attributes
        private string name ;
        private int health ;
        private int maxHealth;
        private int attack;
        private int speed;
        private int defence;

        //below is a constructor method used to create an object
        public Hokemon()
        {
            give_name();
            maxHealth = int_generator(10,100);
            health = maxHealth;
            attack = int_generator(10, 100);
            speed = int_generator(10, 100);
            defence = int_generator(10, 100);

            
        }
        /*public string Name()
        {
            get{ return name; }
            set{
                name = value;
            }
        }*/
        public string getname()
        {
             return name;
         }
        public void get_details()
        {
            Console.WriteLine("health: {0}/{1} \n Attack: {2} \n Speed:{3} \n Defence: {4}", health, maxHealth, attack, speed, defence);
        }
    public void give_name()
        {
            Console.WriteLine("enter the name:");
            name = Console.ReadLine();
        }
    public int int_generator(int minValue, int maxValue)
        {
            Random rnd = new Random();

            int randomValue ;
            randomValue = rnd.Next(minValue, maxValue);

            return randomValue;
        }
    public int Attack_generator()
        {
            int attackValue;

            Random rnd = new Random();
            attackValue = (attack * speed)  /10 * (rnd.Next(0, 3));
            return attackValue;
        }
       public int Defence_generator()
        {
            int defenceValue;

            Random rnd = new Random();
            defenceValue = (defence * speed) /10 * (rnd.Next(0, 2));
            return defenceValue;
        }
    }

}