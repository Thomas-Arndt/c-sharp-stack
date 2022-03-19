using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Bob");
            Human h2 = new Human("Bill", 10, 9, 12, 250);
            Console.WriteLine(h1.Attack(h2));
        }

    }

    class Human {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health { get;set; }

        public Human(string Name) {
            this.Name = Name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.health = 100;
        }

        public Human(string Name, int Strength, int Intelligence, int Dexterity, int health) {
            this.Name = Name;
            this.Strength = Strength;
            this.Intelligence = Intelligence;
            this.Dexterity = Dexterity;
            this.health = health;
        }

        public int Attack(Human target) {
            target.health = target.health - (this.Strength*5);
            return target.health;
        }
    }
}
