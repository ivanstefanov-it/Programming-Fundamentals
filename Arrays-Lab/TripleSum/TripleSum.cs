using System;
using System.Linq;

namespace TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool notFound = true;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] == arr[k])
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[k]}");
                            if (notFound)
                            {
                                notFound = false;
                            }
                            break;
                        }
                       
                    }
                }
            }
            if (notFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
