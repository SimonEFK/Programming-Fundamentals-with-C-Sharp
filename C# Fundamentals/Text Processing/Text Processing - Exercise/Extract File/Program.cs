using System;
using System.Collections.Generic;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("\\")
                .ToList();
            string fileWithExtensions = input[input.Count-1];
            int lastIndex = fileWithExtensions.LastIndexOf('.');
            string fileNmae = fileWithExtensions.Substring(0, lastIndex);
            string fileExtension = fileWithExtensions.Substring(lastIndex+1);

            Console.WriteLine($"File name: {fileNmae}\nFile extension: {fileExtension}");
            
        }
    }
}
