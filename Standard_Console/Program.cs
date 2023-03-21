using System;
using TwistedFizzBuzz_Lib;

namespace Standard_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Range....");
            TwistedFizzBuzz.PrintFizzBuzzRange(1, 100);

            Console.WriteLine("Negative Range....");
            TwistedFizzBuzz.PrintFizzBuzzRange(-37, -2);
        }
    }
}