using System;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double priceOfHall = 1;
            double priceOfPackage = 1;
            double discount = 1;
            double price = 1;
            double pricePerPerson = 1;
            double totalPrice = 1;

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                priceOfHall = 2500;
                if (package == "Normal")
                {
                    priceOfPackage = 500;
                    price = priceOfPackage + priceOfHall;
                    discount = price * 0.05;
                    totalPrice = price - discount;
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    priceOfPackage = 750;
                    price = priceOfPackage + priceOfHall;
                    discount = price * 0.10;
                    totalPrice = price - discount;
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    priceOfPackage = 1000;
                    price = priceOfPackage + priceOfHall;
                    discount = price * 0.15;
                    totalPrice = price - discount;
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                priceOfHall = 5000;
                if (package == "Normal")
                {
                    priceOfPackage = 500;
                    price = priceOfPackage + priceOfHall;
                    discount = price * 0.05;
                    totalPrice = price - discount;
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    priceOfPackage = 750;
                    price = priceOfPackage + priceOfHall;
                    discount = price * 0.10;
                    totalPrice = price - discount;
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    priceOfPackage = 1000;
                    price = priceOfPackage + priceOfHall;
                    discount = price * 0.15;
                    totalPrice = price - discount;
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                priceOfHall = 7500;
                if (package == "Normal")
                {
                    priceOfPackage = 500;
                    price = priceOfPackage + priceOfHall;
                    discount = price * 0.05;
                    totalPrice = price - discount;
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    priceOfPackage = 750;
                    price = priceOfPackage + priceOfHall;
                    discount = price * 0.10;
                    totalPrice = price - discount;
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    priceOfPackage = 1000;
                    price = priceOfPackage + priceOfHall;
                    discount = price * 0.15;
                    totalPrice = price - discount;
                    pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the {hall}");
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else
                Console.WriteLine("We do not have an appropriate hall.");
        }
    }
}
