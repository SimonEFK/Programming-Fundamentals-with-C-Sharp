using System;
using System.Collections.Generic;
using System.Linq;
namespace Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<People> people = new List<People>();
            while (input[0] != "End")
            {
                People currPerson = new People(input[0], input[1], int.Parse(input[2]));
                people.Add(currPerson);
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in people.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }
    }
    class People
    {
        public People(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
