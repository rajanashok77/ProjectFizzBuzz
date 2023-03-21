using System;
using System.Text;
using Xunit;
using TwistedFizzBuzz_Lib;

namespace FizzBuzzTests
{
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var actual = TwistedFizzBuzz.getFizzBuzzOutput(3);
        Assert.Equal("Fizz", actual);
    }

    [Fact]
    public void Test2()
    {
        var actual = TwistedFizzBuzz.getFizzBuzzOutput(5);
        Assert.Equal("Buzz", actual);
    }

    [Fact]
    public void Test3()
    {
        var actual = TwistedFizzBuzz.getFizzBuzzOutput(15);
        Assert.Equal("FizzBuzz", actual);
    }

    [Fact]
    public void Test4()
    {
        var actual = TwistedFizzBuzz.getFizzBuzzOutput(4);
        Assert.Equal("4", actual);
    }

    [Fact]
    public void Test5()
    {
        var dictionary = new Dictionary<string, int>
        {  
            { "Buzz", 5 },
            { "Fizz", 3 }
        };

        var sortedKeyValuePairs = dictionary.OrderBy(x => x.Value).ToList();

        var actual = TwistedFizzBuzz.getFizzBuzzCustomOutput(4, sortedKeyValuePairs);
        Assert.Equal("4", actual);
    }

    [Fact]
    public void Test6()
    {
        var dictionary = new Dictionary<string, int>
        {  
            { "Buzz", 5 },
            { "Fizz", 3 }
        };

        var sortedKeyValuePairs = dictionary.OrderBy(x => x.Value).ToList();

        var actual = TwistedFizzBuzz.getFizzBuzzCustomOutput(5, sortedKeyValuePairs);
        Assert.Equal("Buzz", actual);
    }

    [Fact]
    public void Test7()
    {
        var dictionary = new Dictionary<string, int>
        {  
            { "Buzz", 5 },
            { "Fizz", 3 }
        };

        var sortedKeyValuePairs = dictionary.OrderBy(x => x.Value).ToList();

        var actual = TwistedFizzBuzz.getFizzBuzzCustomOutput(3, sortedKeyValuePairs);
        Assert.Equal("Fizz", actual);
    }

    [Fact]
    public void Test8()
    {
        var dictionary = new Dictionary<string, int>
        {  
            { "Buzz", 5 },
            { "Fizz", 3 }
        };

        var sortedKeyValuePairs = dictionary.OrderBy(x => x.Value).ToList();

        var actual = TwistedFizzBuzz.getFizzBuzzCustomOutput(15, sortedKeyValuePairs);
        Assert.Equal("FizzBuzz", actual);
    }

    [Fact]
    public void Test9()
    {
        var dictionary = new Dictionary<string, int>
        {  
            { "Buzz", 5 },
            { "Fizz", 3 }
        };

        var sortedKeyValuePairs = dictionary.OrderBy(x => x.Value).ToList();

        var actual = TwistedFizzBuzz.getFizzBuzzCustomOutput(-10, sortedKeyValuePairs);
        Assert.Equal("Buzz", actual);
    }

    [Fact]
    public void Test10()
    {
        var dictionary = new Dictionary<string, int>
        {  
            { "Buzz", 5 },
            { "Fizz", 3 }
        };

        var sortedKeyValuePairs = dictionary.OrderBy(x => x.Value).ToList();

        var actual = TwistedFizzBuzz.PrintSequentialOutput(new List<int>() { 3, 4, 5, 15 });

        StringBuilder sb = new StringBuilder();
        foreach (string str in actual)
            {
                sb.Append(str);
                sb.Append(", ");
            }

        Assert.Equal("Fizz, 4, Buzz, FizzBuzz, ", sb.ToString());
    }
}
}