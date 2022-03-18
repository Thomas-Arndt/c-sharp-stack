using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void PrintNumbers()
        {
            for(int idx = 1; idx <= 255; idx++) {
                Console.WriteLine(idx);
            }
        }

        public static void PrintOdds()
        {
            for(int idx = 1; idx <= 255; idx++) {
                if(idx%2 != 0){
                Console.WriteLine(idx);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for(int idx = 1; idx <= 255; idx++) {
                sum += idx;
                Console.WriteLine($"New Number: {idx} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            foreach(int num in numbers) {
                Console.WriteLine(num);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach(int num in numbers) {
                if(num > max) {
                    max = num;
                }
            }
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers) {
                sum += num;
            }
            double avg = (double)sum/numbers.Length;
            Console.WriteLine(avg);
        }

        public static int[] OddArray()
        {
            List<int> oddList = new List<int>();
            for(int idx = 1; idx <= 255; idx++) {
                if(idx%2 != 0) {
                    oddList.Add(idx);
                }
            }
            int[] odds = new int[oddList.Count];
            for(int idx = 0; idx < oddList.Count; idx++) {
                odds[idx] = oddList[idx];
            }
            return odds;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            foreach(int num in numbers) {
                if(num > y) {
                    count++;
                }
            }
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for(int idx = 0; idx < numbers.Length; idx++) {
                numbers[idx] = (int)Math.Pow(numbers[idx], 2);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for(int idx = 0; idx < numbers.Length; idx++) {
                if(numbers[idx] < 0) {
                    numbers[idx] = 0;
                }
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            foreach(int num in numbers) {
                if(num > max) {
                    max = num;
                }
                if(num < min) {
                    min = num;
                }
                sum += num;
            }
            double avg = (double)sum/numbers.Length;
            Console.WriteLine($"Min: {min} | Max: {max} | Avg: {avg}");
        }

        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for(int idx = 0; idx < numbers.Length; idx++) {
                if(idx == numbers.Length) {
                    numbers[idx] = 0;
                } else {
                    numbers[idx] = numbers[idx+1];
                }
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] objectArray = new object[numbers.Length];
            for(int idx = 0; idx < numbers.Length; idx++) {
                if(numbers[idx] >= 0) {
                    objectArray[idx] = numbers[idx];
                } else {
                    objectArray[idx] = "Dojo";
                }
            }
            return objectArray;
        }





    }
}
