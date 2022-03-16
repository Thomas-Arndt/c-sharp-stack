using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> objectList = new List<object>();
            objectList.Add(7);
            objectList.Add(28);
            objectList.Add(-1);
            objectList.Add(true);
            objectList.Add("chair");
            int sum = 0;
            foreach(object obj in objectList) {
                Console.WriteLine(obj);
                if(obj is int) {
                    sum += (int)obj;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
