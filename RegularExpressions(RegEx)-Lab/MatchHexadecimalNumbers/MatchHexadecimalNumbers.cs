using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);

            string[] matched = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", matched));

        }
    }
}
