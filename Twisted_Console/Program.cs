using System;
using TwistedFizzBuzz_Lib;

namespace Twisted_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = TwistedFizzBuzz.PrintSequentialOutput(new List<int>() { 3, 4, 5, 15 });

            Console.WriteLine("Non-Sequential Range.....");
            foreach (string str in output)
            {
                System.Console.Write(str +", ");  
            }
            System.Console.WriteLine();

            Console.WriteLine("Range for custom token and divisor.....");
            var dictionary = new Dictionary<string, int>
            {  
                { "Buzz", 9 },
                { "Fizz", 5 },
                { "Bar", 27 }
            };

            var sortedKeyValuePairs = dictionary.OrderBy(x => x.Value).ToList();

            TwistedFizzBuzz.PrintCustomRange(-20, 127, sortedKeyValuePairs);
        }
    }
}