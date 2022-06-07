using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double nuts = 2;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1; ;
            //bool isInputStart = false;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                double coins = double.Parse(input);
                bool correctCoins = (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2);
                if (correctCoins)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

            }

            while (true)
            {
                string product = Console.ReadLine();
                if (product == "End")
                {
                    Console.WriteLine($"Change: {sum:f2}");
                    return;
                }
                if (product == "Nuts")
                {
                    if (sum >= 2)
                    {
                        Console.WriteLine("Purchased nuts");
                        sum -= 2;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (sum >= 0.7)
                    {
                        Console.WriteLine("Purchased water");
                        sum -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (sum >= 1.5)
                    {
                        Console.WriteLine("Purchased crisps");
                        sum -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (sum >= 0.8)
                    {
                        Console.WriteLine("Purchased soda");
                        sum -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (sum >= 1)
                    {
                        Console.WriteLine("Purchased coke");
                        sum -= 1;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid product");
                }

            }
        }
    }
}
