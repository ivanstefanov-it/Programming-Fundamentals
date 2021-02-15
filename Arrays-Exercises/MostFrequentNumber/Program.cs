using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            int counterMax = 0;
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                        if (counter > counterMax)
                        {
                            counterMax = counter;
                            result = arr[i];
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
