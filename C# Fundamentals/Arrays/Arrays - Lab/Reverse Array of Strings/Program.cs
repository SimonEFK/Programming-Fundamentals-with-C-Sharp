using System;
using System.Linq;

namespace __Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));


        }
    }
}
