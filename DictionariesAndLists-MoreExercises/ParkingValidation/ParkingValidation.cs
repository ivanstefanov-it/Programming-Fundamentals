﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingValidation
{
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registredUsersAndPlates = new Dictionary<string, string>();

            int entrtiesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < entrtiesCount; i++)
            {
                string[] commnadList = Console.ReadLine().Split(' ');
                string instruction = commnadList[0];
                string user = commnadList[1];
                if (instruction == "register")
                {
                    string plate = commnadList[2];

                    if (registredUsersAndPlates.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registredUsersAndPlates[user]}");
                        continue;
                    }
                    if (IsPlateInvalid(plate))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                        continue;
                    }
                    if (registredUsersAndPlates.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                        continue;
                    }
                    registredUsersAndPlates[user] = plate;
                    Console.WriteLine($"{user} registered {plate} successfully");

                }

                if (instruction == "unregister")
                {
                    if (!registredUsersAndPlates.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                        continue;
                    }
                    registredUsersAndPlates.Remove(user);
                    Console.WriteLine($"user {user} unregistered successfully");
                }
            }

            foreach (var user in registredUsersAndPlates)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static bool IsPlateInvalid(string plate)
        {
            if (plate.Length != 8)
            {
                return true;
            }
            string firstLastTwoSymbols = plate.Substring(0, 2) + plate.Substring(6);
            foreach (var symbol in firstLastTwoSymbols)
            {
                if (symbol < 'A' || 'Z' < symbol)
                {
                    return true;
                }
            }
            string midleSymbols = plate.Substring(2, 4);
            foreach (var symbol in midleSymbols)
            {
                if (symbol < '0' || '9' < symbol)
                {
                    return true;
                }
            }

            return false;
        }
    }
}