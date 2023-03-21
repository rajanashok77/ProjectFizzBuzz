using System;
using System.Text;
namespace TwistedFizzBuzz_Lib
{
public static class TwistedFizzBuzz
{
    // Prints a simple FizzBuzz pattern given a start and end value
    public static void PrintFizzBuzzRange(int start, int end)
    {
        if (start < end) 
        {
            for(int i = start; i <= end; i++)
            {
                Console.WriteLine(getFizzBuzzOutput(i));
            }
        }
    }

    // Prints a twisted FizzBuzz pattern for a given range and custom token and divisors passed as KeyValue Pairs
    public static void PrintCustomRange(int start, int end, List<KeyValuePair<string, int>> list)
    {
        if (start < end) 
        {
            for(int i = start; i <= end; i++)
            {
                Console.WriteLine(getFizzBuzzCustomOutput(i, list));
            }
        }
    }

    // Prints the FizzBuzz pattern for a given list of non sequential numbers
    public static List<string> PrintSequentialOutput(List<int> list)
    {
        List<string> output = new List<string>();
        foreach(int num in list)
        {
            output.Add(getFizzBuzzOutput(num));
        }
        return output;
    }

    // Constructs a simple FizzBuzz pattern string for a given number
    public static string getFizzBuzzOutput(int num)
    {
        if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
            else if (num % 3 == 0) return "Fizz";
            else if (num % 5 == 0) return "Buzz";
        return num.ToString();
    }

    // Constructs a Custom FizzBuzz pattern for a given number and a custom token divisor key value pairs.
    public static string getFizzBuzzCustomOutput(int num, List<KeyValuePair<string, int>> list)
    {
        StringBuilder sb = new StringBuilder("");
        foreach(KeyValuePair<string, int> pair in list)
            {
                if (num % pair.Value == 0) sb = sb.Append(pair.Key);
            }

        if (sb.ToString().Equals("")) return num.ToString();
        else return sb.ToString();
    }
}
}
