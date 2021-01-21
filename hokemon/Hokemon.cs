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
       // public string team;

        //below is a constructor method used to create an object
        public Hokemon()
        {
            give_name();
            maxHealth = int_generator(10,100);
            health = maxHealth;
            attack = int_generator(10, 100);
            speed = int_generator(10, 50);
            defence = int_generator(10, 20);
          //  team = "N/A";
            
        }
        public string Name
        {
            get{ return name; }
            set{
                name = value;
            }
        }
        public int Health
        {
            get{ return health; }
            set{
                health = value;
            }
        }
        public string getname()
        {
             return name;
         }
        public void get_details()
        {
            Console.WriteLine("health: {0}/{1} \nAttack: {2} \nSpeed:{3} \nDefence: {4} ", health, maxHealth, attack, speed, defence);
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
            attackValue = (attack * speed)  /10 * (rnd.Next(0,2));
            return attackValue;
        }
       public int Defence_generator()
        {
            int defenceValue;

            Random rnd = new Random();
            defenceValue = ((defence * speed) /10 * (rnd.Next(0, 2)));
            return defenceValue;
        }      
        public void definition()
        {
            Console.WriteLine("I am {0} ,a member of the hokemon tribe", name);
        }
    }

}