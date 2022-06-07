using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var plates = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];
                string name = input[1];

                if (command == "register")
                {
                    string plateNumber = input[2];

                    if (!(plates.ContainsKey(name)))
                    {
                        plates[name] = plateNumber;
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else
                {
                    string plateNumber = input[1];
                    if (plates.ContainsKey(plateNumber))
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        plates.Remove(name);

                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }

            }
            foreach (var item in plates)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
