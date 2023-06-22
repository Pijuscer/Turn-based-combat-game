using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detail
{
    //klase ir objektai
    //(Setters/Getters)
    abstract class Player
    {
        public int Health { get; set; }
        public int Shield { get; set; }

        public int Hit { get; set; }
        public int Pierce { get; set; }
        public int Potions { get; set; }
        public int PotionsNumber { get; set; }

        //Inkapsuliacija
        //Konstruktorius
        public Player()
        {

            this.Health = 100;
            this.Shield = 10;
            this.Hit = 12;
            this.Pierce = 20;
            this.Potions = 30;
            this.PotionsNumber = 5;
        }


    }
    //(Setters/Getters)
    //klase ir objektai
    //Priešo aprašymas
    class Enemy
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Shield { get; set; }
        public int Level { get; set;}
        public Enemy(int level)


       
        {
            this.Health = 100 + (10 * level);
            this.Damage = 30;
            this.Shield = 10;
            //Enemy.Level = 1;
            this.Level = level;


        }

        
        //destruktorius
        ~Enemy()
        {

            Console.WriteLine("The enemy is destroyed!");
        }
    }
    //klase ir objektai
    //(Setters/Getters)
    //Paveldimumas
    //Tavo kovotojo puolimo tipai
    class Warrior : Player
    {
        private int Hit { get; set; }
        private int Pierce { get; set; }
        private int Heal { get; set; }

        public Warrior()
        {
            this.Hit = 10;
            this.Pierce = 20;
            this.Heal = 30;
        }

    }
}
