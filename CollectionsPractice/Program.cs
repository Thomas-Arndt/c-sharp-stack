using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] singleDigitNums = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] alternatingBool = {true, false, true, false, true, false, true, false, true, false};

            List<string> iceCream = new List<string>();
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate");
            iceCream.Add("Strawberry");
            iceCream.Add("Cookies'n'Cream");
            iceCream.Add("Salted Caramel");
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine(iceCream.Count);

            Dictionary<string,string> favoriteIceCream = new Dictionary<string,string>();
            Random randomGenerator = new Random();
            for(int i = 0; i < names.Length; i++) {
                favoriteIceCream.Add(names[i], iceCream[randomGenerator.Next(iceCream.Count)]);
            }
            foreach(var entry in favoriteIceCream) {
                Console.WriteLine($"{entry.Key} likes {entry.Value}");
            }
        }
    }
}
