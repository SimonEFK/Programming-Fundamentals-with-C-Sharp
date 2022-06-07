using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Regex pattern = new Regex(@"%(?<name>[A-Z]{1}[a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*\$)");
            double total = 0;
            
            while (input != "end of shift")
            {
                MatchCollection matches = pattern.Matches(input);


                foreach (Match item in matches)
                {
                    string name = item.Groups["name"].Value;
                    string product = item.Groups["product"].Value;
                    int count = int.Parse(item.Groups["count"].Value);
                    double price = double.Parse(item.Groups["price"].Value.Trim('$'));
                    Console.WriteLine($"{name}: {product} - {count * price:f2}");
                    total += price * count;
                }









                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:F2}");
        }
    }
}
