using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var productList = new Dictionary<string, List<double>>();
            while (input != "buy")
            {
                string[] cmdArg = input.Split(" ");
                string product = cmdArg[0];
                double price = double.Parse(cmdArg[1]);
                double quantity = double.Parse(cmdArg[2]);

                if (!(productList.ContainsKey(product)))
                {
                    productList.Add(product, new List<double>());
                    productList[product].Add(price);
                    productList[product].Add(quantity);
                    
                }
                else
                {
                    productList[product] [0] = price;
                    productList[product] [1] += quantity;
                }
                

                input = Console.ReadLine();
            }
            foreach (var item in productList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
}
