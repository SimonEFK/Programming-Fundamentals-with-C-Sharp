using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequance = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> graveyard = new List<int>();

            while (sequance.Count > 0)
            {
                int input = int.Parse(Console.ReadLine());

                if (input >= 0 && input < sequance.Count)
                {
                    int removedPokemon = sequance[input];
                    graveyard.Add(removedPokemon);
                    sequance.RemoveAt(input);
                    for (int i = 0; i < sequance.Count; i++)
                    {
                        if (sequance[i] <= removedPokemon)
                        {
                            sequance[i] += removedPokemon;
                        }
                        else if (sequance[i] > removedPokemon)
                        {
                            sequance[i] -= removedPokemon;
                        }
                    }
                }
                else if (input >= sequance.Count)
                {
                    int removedPokemon = sequance[sequance.Count - 1];
                    graveyard.Add(removedPokemon);
                    sequance[sequance.Count - 1] = sequance[0];
                    for (int i = 0; i < sequance.Count; i++)
                    {
                        if (sequance[i] <= removedPokemon)
                        {
                            sequance[i] += removedPokemon;
                        }
                        else if (sequance[i] > removedPokemon)
                        {
                            sequance[i] -= removedPokemon;
                        }
                    }
                }
                else if (input < 0)
                {
                    int removedPokemon = sequance[0];
                    graveyard.Add(removedPokemon);
                    sequance[0] = sequance[sequance.Count - 1];
                    for (int i = 0; i < sequance.Count; i++)
                    {
                        if (sequance[i] <= removedPokemon)
                        {
                            sequance[i] += removedPokemon;
                        }
                        else if (sequance[i] > removedPokemon)
                        {
                            sequance[i] -= removedPokemon;
                        }
                    }
                }
            }


            Console.Write(graveyard.Sum());
        }
    }
}
