using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var cmdArg = new string[input.Length];
            if (input.Contains(" | "))
            {
                cmdArg = input.Split(" | ");

            }
            else
            {
                cmdArg = input.Split(" -> ");
            }
            string forceUser = string.Empty;
            string forceSide = string.Empty;
            bool containsForceUser = false;


            var usersDictionary = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {

                if (input.Contains(" | "))
                {
                    cmdArg = input.Split(" | ");
                    forceUser = cmdArg[1];
                    forceSide = cmdArg[0];
                    if (!(usersDictionary.ContainsKey(forceSide)))
                    {
                        usersDictionary.Add(forceSide, new List<string>());

                    }

                    if (!(usersDictionary.Values.Any(x => x.Contains(forceUser))))
                    {
                        usersDictionary[forceSide].Add(forceUser);
                    }



                }
                else if (input.Contains(" -> "))
                {



                    cmdArg = input.Split(" -> ");
                    forceUser = cmdArg[0];
                    forceSide = cmdArg[1];

                    foreach (var side in usersDictionary)
                    {
                        foreach (var item in side.Value)
                        {
                            if (item == forceUser)
                            {
                                containsForceUser = true;
                                side.Value.Remove(forceUser);
                                break;
                            }
                        }
                    }
                    if (containsForceUser == true)
                    {
                        if (!(usersDictionary.ContainsKey(forceSide)))
                        {
                            usersDictionary.Add(forceSide, new List<string>());
                        }
                        usersDictionary[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        if (!(usersDictionary.ContainsKey(forceSide)))
                        {
                            usersDictionary.Add(forceSide, new List<string> { forceUser });
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");

                        }
                        else
                        {
                            if (!(usersDictionary[forceSide].Contains(forceUser)))
                            {
                                usersDictionary[forceSide].Add(forceUser);
                                Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                            }
                        }
                    }

                }
                input = Console.ReadLine();
                containsForceUser = false;
            }



            foreach (var side in usersDictionary
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {

                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var item in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {item}");
                }
            }
        }
    }
}
