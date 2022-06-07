using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PasswordValidator(input);
        }

        private static void PasswordValidator(string input)
        {
            bool unvalidLenght = false;
            if (input.Length < 6 || input.Length > 10)
            {
                unvalidLenght = true;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            bool unvalidSymbol = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetterOrDigit(input[i]) == false)
                {
                    unvalidSymbol = true;
                    break;
                }
            }
            if (unvalidSymbol == true)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }
            int digitCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digitCount++;
                }
                if (digitCount == 2)
                {
                    break;
                }
            }
            if (digitCount < 2)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }
            bool validPassword = unvalidSymbol == false && digitCount >= 2 && unvalidLenght == false;
            if (validPassword)
            {
                Console.WriteLine($"Password is valid");
            }
        }
    }
}
