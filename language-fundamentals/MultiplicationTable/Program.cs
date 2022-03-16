using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplicationTable = new int[10,10];
            for(int i = 1; i <= 10; i++) {
                for(int j = 1; j <= 10; j++) {
                    multiplicationTable[i-1,j-1] = i*j;
                }
            }
            for(int idx = 0; idx < 10; idx++) {
                string output = "[";
                for(int idx2 = 0; idx2 < 10; idx2++) {
                    output += multiplicationTable[idx,idx2].ToString() + ", ";
                }
                Console.WriteLine($"{output}]\n");
            }
        }
    }
}
