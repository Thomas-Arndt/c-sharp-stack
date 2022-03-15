using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int j=1; j<=255; j++) {
                Console.WriteLine(j);
            }
            for(int k=1; k <= 100; k++) {
                if((k%3 == 0 || k%5 == 0) && k%15 != 0) {
                    Console.WriteLine(k);
                }
            }
            int i = 1;
            while(i <= 100) {
                if(i%15 == 0) {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if(i%5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
