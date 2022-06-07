using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"[A-Za-z0-9-0*.\/]+");
            Regex damageCalc = new Regex(@"[+-]?[0-9]+\.?[0-9]*");
            Regex divideOrNah = new Regex(@"[*\/]");

            int health = 0;
            double damage = 0.0;
            string currentMonster = string.Empty;

            MatchCollection matches = pattern.Matches(input);

            MatchCollection numberMatches = damageCalc.Matches(input);

            MatchCollection divideOrNahMatches = divideOrNah.Matches(input);

            string monsterName = string.Empty;
            var result = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < matches.Count; i++)
            {
                numberMatches = damageCalc.Matches(matches[i].ToString());
                divideOrNahMatches = divideOrNah.Matches(matches[i].ToString());

                currentMonster = matches[i].ToString();

                foreach (char character in matches[i].ToString())
                {
                    if (char.IsLetter(character))
                    {
                        health += (char)character;
                    }
                }
                if (!(result.ContainsKey(currentMonster)))
                {
                    result.Add(currentMonster, new List<double>() { health });

                }



                for (int k = 0; k < numberMatches.Count; k++)
                {
                    double currNum = double.Parse(numberMatches[k].ToString());
                    damage += currNum;
                }
                for (int j = 0; j < divideOrNahMatches.Count; j++)
                {
                    if (divideOrNahMatches[j].ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else if (divideOrNahMatches[j].ToString() == "/")
                    {
                        damage /= 2;
                    }
                }
                result[currentMonster].Add(damage);
                health = 0;
                damage = 0;

            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }


        }
    }
}
