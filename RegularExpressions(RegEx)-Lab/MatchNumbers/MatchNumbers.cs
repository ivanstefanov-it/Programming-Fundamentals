using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
        string input = Console.ReadLine();
        var numbers = Regex.Matches(input, pattern);

        foreach (Match number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
