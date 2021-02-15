using System;

namespace EnglishNameОfLastDigit
{
    class EnglishNameОfLastDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string output = EnglishNameOfLastDigits(number);
            Console.WriteLine(output);
           
        }
        static string EnglishNameOfLastDigits(int num)
        {
            string result = "";
            int number = num % 10;
            switch (number)
            {
                case 0:
                   result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }
            return result;
        }
    }
}
