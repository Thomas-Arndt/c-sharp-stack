using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int[] RandomArray() {
            Random rand = new Random();
            int[] randomArray = new int[10];
            int min = 26;
            int max = 0;
            int sum = 0;
            for(int idx = 0; idx < 10; idx++) {
                randomArray[idx] = rand.Next(5,26);
                if(randomArray[idx] > max) {
                    max = randomArray[idx];
                }
                if(randomArray[idx] < min) {
                    min = randomArray[idx];
                }
                sum += randomArray[idx];
            }
            Console.WriteLine($"Min: {min} | Max: {max} | Sum: {sum}");
            return randomArray;
        }

        public static string TossCoin() {
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            int toss = rand.Next(0,2);
            string result = "";
            if(toss == 1) {
                result = "Heads";
            } else {
                result = "Tails";
            }
            Console.WriteLine(result);
            return result;
        }

        public static Double TossMultipleCoins(int num) {
            Random rand = new Random();
            Double sum = 0;
            for(int idx = 0; idx < num; idx++) {
                sum += rand.Next(0,2);
            }
            Double ratio = sum/num;
            return ratio;
        }

        public static List<string> Names(List<string> names) {
            Random rand = new Random();
            List<string> localNames = new List<string>();
            foreach(string name in names) {
                localNames.Add(name);
            }
            List<string> shuffledNames = new List<string>();
            while(localNames.Count > 0) {
                int randIndex = rand.Next(0,localNames.Count);
                shuffledNames.Add(localNames[randIndex]);
                Console.WriteLine(localNames[randIndex]);
                localNames.RemoveAt(randIndex);
            }
            for(int idx = 0; idx < shuffledNames.Count; idx++) {
                if(shuffledNames[idx].Length > 5) {
                    localNames.Add(shuffledNames[idx]);
                }
            }
            return localNames;
        }

    }
}
