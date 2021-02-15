using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
        string input = Console.ReadLine();

        var matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.Write(match.Value + " ");
        }
       
    }
}
