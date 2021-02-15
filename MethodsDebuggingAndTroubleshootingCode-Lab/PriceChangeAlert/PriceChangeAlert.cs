﻿using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double difference = Proxy(price, nextPrice);
            bool isSignificantDifference = IsEnoughDiff(difference, threshold);
            string message = Get(nextPrice, price, difference, isSignificantDifference);
            Console.WriteLine(message);
            price = nextPrice;
        }
    }

    private static string Get(double nextPrice, double price, double difference, bool etherTrueOrFalse)
    {
        string result = "";
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", nextPrice);
            return result;
        }
        else if (!etherTrueOrFalse)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            return result;
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            return result;
        }
        else if (etherTrueOrFalse && (difference < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            return result;
        }
        return result;
           
        
    }
    private static bool IsEnoughDiff(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proxy(double lastPrice, double currPrice)
    {
        double result = (currPrice - lastPrice) / lastPrice;
        return result;
    }
}
