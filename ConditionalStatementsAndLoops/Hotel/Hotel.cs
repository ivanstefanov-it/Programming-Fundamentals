using System;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            double studioPrice = 1;
            double doublePrice = 1;
            double masterSuitePrice = 1;

            if (month == "May" || month == "October")
            {
                if (month == "October")
                {
                    studioPrice = 50 * (nightCount - 1);
                    doublePrice = 65 * nightCount;
                    masterSuitePrice = 75 * nightCount;
                    if (nightCount > 7)
                    {
                        studioPrice *= 0.95;
                    }
                }
                else
                {
                    studioPrice = 50 * nightCount;
                    doublePrice = 65 * nightCount;
                    masterSuitePrice = 75 * nightCount;
                    if (nightCount > 7)
                    {
                        studioPrice *= 0.95;
                    }
                }
               
                Console.WriteLine($"Studio: {studioPrice:F2} lv.");
                Console.WriteLine($"Double: {doublePrice:F2} lv.");
                Console.WriteLine($"Suite: {masterSuitePrice:F2} lv.");
            }
            else if (month == "June" || month == "September")
            {
                if (month == "September")
                {
                    studioPrice = 60 * (nightCount - 1);
                    doublePrice = 72 * nightCount;
                    masterSuitePrice = 82 * nightCount;
                    if (nightCount > 14)
                    {
                        doublePrice *= 0.90;
                    }
                }
                else
                {
                    studioPrice = 60 * nightCount;
                    doublePrice = 72 * nightCount;
                    masterSuitePrice = 82 * nightCount;
                    if (nightCount > 14)
                    {
                        doublePrice *= 0.90;
                    }
                }
                Console.WriteLine($"Studio: {studioPrice:F2} lv.");
                Console.WriteLine($"Double: {doublePrice:F2} lv.");
                Console.WriteLine($"Suite: {masterSuitePrice:F2} lv.");
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68 * nightCount;
                doublePrice = 77 * nightCount;
                masterSuitePrice = 89 * nightCount;
                if (nightCount > 14)
                {
                    masterSuitePrice *= 0.85;
                }
                Console.WriteLine($"Studio: {studioPrice:F2} lv.");
                Console.WriteLine($"Double: {doublePrice:F2} lv.");
                Console.WriteLine($"Suite: {masterSuitePrice:F2} lv.");
            }
        }
    }
}
