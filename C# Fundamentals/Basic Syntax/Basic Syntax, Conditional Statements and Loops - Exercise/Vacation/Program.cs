using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfStudents = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double discount = 0;
            switch (day)
            {
                case "Friday":
                    if (type == "Students")
                    {
                        price = 8.45 * numOfStudents;
                        if (numOfStudents >= 30)
                        {
                            discount = price * 0.15;
                            price -= discount;
                        }

                    }
                    else if (type == "Business")
                    {
                        price = 10.90 * numOfStudents;
                        if (numOfStudents >= 100)
                        {
                            numOfStudents -= 10;                            
                            price = numOfStudents*10.90;
                        }
                    }
                    else if (type == "Regular")
                    {
                        price = numOfStudents * 15;
                        if (numOfStudents >= 10 && numOfStudents <= 20)
                        {
                            discount = price * 0.05;
                            price -= discount;
                        }
                    }
                    break;
                case "Saturday":
                    if (type == "Students")
                    {
                        price = 9.80 * numOfStudents;
                        if (numOfStudents >= 30)
                        {
                            discount = price * 0.15;
                            price -= discount;
                        }

                    }
                    else if (type == "Business")
                    {
                        price = 15.60 * numOfStudents;
                        if (numOfStudents >= 100)
                        {
                            numOfStudents -= 10;
                            price = numOfStudents * 15.60;
                        }
                    }
                    else if (type == "Regular")
                    {
                        price = numOfStudents * 20;
                        if (numOfStudents >= 10 && numOfStudents <= 20)
                        {
                            discount = price * 0.05;
                            price -= discount;
                        }
                    }
                    break;
                case "Sunday":
                    if (type == "Students")
                    {
                        price = 10.46 * numOfStudents;
                        if (numOfStudents >= 30)
                        {
                            discount = price * 0.15;
                            price -= discount;
                        }

                    }
                    else if (type == "Business")
                    {
                        price = 16 * numOfStudents;
                        if (numOfStudents >= 100)
                        {
                            numOfStudents -= 10;
                            price = numOfStudents * 16;
                        }
                    }
                    else if (type == "Regular")
                    {
                        price = numOfStudents * 22.50;
                        if (numOfStudents >= 10 && numOfStudents <= 20)
                        {
                            discount = price * 0.05;
                            price -= discount;
                        }
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
