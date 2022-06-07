using System;
using System.Collections.Generic;
using System.Linq;


namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicles> vehicles = new List<Vehicles>();

            while (input != "End")
            {
                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Vehicles currVehicle = new Vehicles(info[0], info[1], info[2], int.Parse(info[3]));
                vehicles.Add(currVehicle);

                input = Console.ReadLine();
            }
            string inputBet = Console.ReadLine();
            while (inputBet != "Close the Catalogue")
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].Model == inputBet)
                    {
                        Console.WriteLine($"Type: {vehicles[i].Type}\nModel: {vehicles[i].Model}\nColor: {vehicles[i].Color}\nHorsepower: {vehicles[i].HorsePower}");
                        break;
                    }
                }

                inputBet = Console.ReadLine();
            }
            int carsCount = 0;
            int trucksCount = 0;
            double carsSum = 0;
            double trucksSum = 0;
            foreach (var item in vehicles)
            {
                if (item.Type == "Car")
                {
                    carsCount++;
                    carsSum += item.HorsePower;
                }
                else
                {
                    trucksCount++;
                    trucksSum += item.HorsePower;
                }
            }
            double carsAvgSpeed = carsSum / carsCount;
            double trucksAvgSpeed = trucksSum / trucksCount;
            PrintResult(carsCount, trucksCount, carsAvgSpeed, trucksAvgSpeed);

        }

        private static void PrintResult(int carsCount, int trucksCount, double carsAvgSpeed, double trucksAvgSpeed)
        {
            if (carsCount == 0 && trucksCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.\nTrucks have average horsepower of: {trucksAvgSpeed:f2}.");
            }
            else if (carsCount > 0 && trucksCount == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsAvgSpeed:f2}.\nTrucks have average horsepower of: {0:f2}.");
            }
            else if (carsCount == 0 && trucksCount == 0)
            {

                Console.WriteLine($"Cars have average horsepower of: {0:f2}.\nTrucks have average horsepower of: {0:f2}.");



            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {carsAvgSpeed:f2}.\nTrucks have average horsepower of: {trucksAvgSpeed:f2}.");
            }
        }
    }



    class Vehicles
    {
        public Vehicles(string type, string model, string color, int horsepower)
        {
            if (type == "car")
            {
                Type = "Car";
            }
            else if (type == "truck")
            {
                Type = "Truck";
            }
            Model = model;
            Color = color;
            HorsePower = horsepower;

        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }



    }
}


