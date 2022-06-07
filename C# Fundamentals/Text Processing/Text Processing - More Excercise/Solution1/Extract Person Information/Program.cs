using System;
using System.Linq; 

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                int index = input.IndexOf('@')+1;
                int endIndex = input.IndexOf('|');
                string name = input.Substring(index, endIndex - index);
                index = input.IndexOf('#')+1;
                endIndex = input.IndexOf('*');
                string age = input.Substring(index, endIndex - index );
                int ageToInt = int.Parse(age);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
        

    }
}
