using System;

namespace __Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            PrintTotalCost(product, amount);

        }
        static void PrintTotalCost(string product,double amount)
        {
            double total = 0.0;

            if (product=="coffee")
            {
                total = amount * 1.50;
            }
            else if (product=="water")
            {
                total = amount * 1.00;
            }
            else if (product=="coke")
            {
                total = amount * 1.40;
            }
            else if (product== "snacks" )
            {
                total = amount * 2.00;
            }
             Console.Write($"{total:f2}");
        }
    }
}
