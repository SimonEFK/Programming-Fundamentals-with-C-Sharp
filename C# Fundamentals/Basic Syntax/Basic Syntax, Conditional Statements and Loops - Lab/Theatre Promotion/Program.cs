using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
            switch (day)
            {
                case "Holiday":
                    if (age <= 18 && age >= 0)
                    {
                        ticketPrice = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketPrice = 12;
                    }
                    else if (age >= 64 && age <= 122)
                    {
                        ticketPrice = 10;
                    }
                    break;
                case "Weekday":
                    if ((age <= 18 && age >= 0) || (age > 64 && age <= 122))
                    {
                        ticketPrice = 12;
                    }
                    else
                    {
                        ticketPrice = 18;
                    }
                    break;
                case "Weekend":
                    if ((age <= 18 && age >= 0) || (age > 64 && age <= 122))
                    {
                        ticketPrice = 15;
                    }
                    else
                    {
                        ticketPrice = 20;
                    }
                    break;
                default:
                    break;
            }
            if (age > 122 || age < 0)//|| (ticketPrice <= 0))
            {
                Console.WriteLine($"Error!");
            }
            else
            {
                Console.WriteLine($"{ticketPrice}$");
            }
        }
    }
}
