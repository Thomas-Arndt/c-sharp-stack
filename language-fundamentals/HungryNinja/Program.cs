using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffy = new Buffet();
            Ninja ninja = new Ninja();
            while(!ninja.isFull()) {
            ninja.Eat(buffy.Serve());
            }
            ninja.Eat(buffy.Serve());
        }
    }

    class Food {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string Name, int Calories, bool IsSpicy, bool IsSweet) {
            this.Name = Name;
            this.Calories = Calories;
            this.IsSpicy = IsSpicy;
            this.IsSweet = IsSweet;
        }

    }
    class Buffet {
        public List<Food> Menu;

        public Buffet() {
            this.Menu = new List<Food>() {
                new Food("burrito", 1000, true, false),
                new Food("tacos", 800, true, false),
                new Food("nachos", 1400, true, false),
                new Food("enchiladas", 1400, true, false),
                new Food("tamales", 1000, true, false),
                new Food("ice cream", 800, false, true),
                new Food("jalapeno margarita", 700, true, true),
            };
        }

        public Food Serve() {
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0,this.Menu.Count);
            return this.Menu[randomIndex];
        }
    }

    class Ninja {
        private int calorieIntake;
        public List<Food> foodHistory;

        public Ninja() {
            this.calorieIntake = 0;
            this.foodHistory = new List<Food>();
        }

        public Boolean isFull() {
            if(this.calorieIntake > 4400) {
                return true;
            }
            return false;
        }

        public void Eat(Food item) {
            if(!this.isFull()) {
                this.calorieIntake += item.Calories;
                foodHistory.Add(item);
                string foodInfo = "Ninja eats " + item.Name + ".";
                if(item.IsSpicy) {
                    foodInfo += " It is spicy.";
                }
                if(item.IsSweet) {
                    foodInfo += " It is sweet.";
                }
                Console.WriteLine(foodInfo);
            } else {
                Console.WriteLine("Ninja is too full to eat more.");
            }
        }

    }

}
