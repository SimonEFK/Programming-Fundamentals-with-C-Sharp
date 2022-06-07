using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            bool isValid = false;
            StringBuilder validUsernames = new StringBuilder();



            foreach (var usernames in input)
            {
                if (usernames.Length >= 3 && usernames.Length <= 16)
                {


                    foreach (char character in usernames)
                    {
                        if (char.IsLetterOrDigit(character)
                            || character == '-'
                            || character == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }

                    }
                    if (isValid == true)
                    {
                        validUsernames.Append(usernames + Environment.NewLine);
                    }

                }
            }
            Console.Write(validUsernames);
        }
    }
}
