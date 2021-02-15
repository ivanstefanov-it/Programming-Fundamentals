using System;
using System.Text;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)([\\\|<])(.*)([\\\|<])([A-Za-z]+)";
            string input = Console.ReadLine();
            Match match = Regex.Match(input, pattern);
            string start = match.Groups[1].Value;
            string end = match.Groups[5].Value;
            string secondInput = Console.ReadLine();
            string secondPattern = $@"{start}(.*?){end}";
            StringBuilder sb = new StringBuilder();
            MatchCollection result = Regex.Matches(secondInput, secondPattern);

            foreach (Match m in result)
            {
                sb.Append(m.Groups[1].Value);
            }
            if (sb.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
            Console.WriteLine(sb);
            }
        }
    }
}
