using System;

namespace CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int totalCaloories = 0;
            string ingredients = "";

            for (int i = 0; i < n; i++)
            {
                ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    totalCaloories += cheese;
                }
                else if (ingredients == "tomato sauce")
                {
                    totalCaloories += tomatoSauce;
                }
                else if (ingredients == "salami")
                {
                    totalCaloories += salami;
                }
                else if (ingredients == "pepper")
                {
                    totalCaloories += pepper;
                }
            }
            Console.WriteLine($"Total calories: {totalCaloories}");
        }
    }
}
