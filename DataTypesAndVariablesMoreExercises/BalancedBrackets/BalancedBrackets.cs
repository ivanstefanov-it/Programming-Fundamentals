using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string lines = "";
            int left = 0;
            int right = 0;

            for (int i = 1; i <= n; i++)
            {
                lines = Console.ReadLine();
                if (lines == "(")
                {
                    left++;
                }
                if (lines == ")")
                {
                    right++;
                }
            }
            if (left == right)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
