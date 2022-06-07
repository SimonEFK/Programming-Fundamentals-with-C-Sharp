using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern =  new Regex(@">>(?<product>[A-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)");
            string input = Console.ReadLine();
            double total = 0.0;
            StringBuilder furnitures = new StringBuilder();


            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                Match matched = pattern.Match(input);
                if (matched.Success)
                {
                    
                    string productName = matched.Groups["product"].Value;
                    Console.WriteLine(productName);
                    furnitures.AppendLine(productName);

                    double price = double.Parse(matched.Groups["price"].Value);
                    int quanty = int.Parse(matched.Groups["quantity"].Value);

                    

                    total += price * quanty;
                    
                }

                input = Console.ReadLine();
            }
            
            //Console.Write(furnitures);
            Console.Write($"Total money spend: {total:f2}");
        }
    }
}
