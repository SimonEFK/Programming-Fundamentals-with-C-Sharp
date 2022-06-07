using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            

            Regex decryptor = new Regex(@"[STARstar]");
            Regex decryptorBeta = new Regex(@"@(?<planetName>[A-z]+)[^@,\-!:>]*?:(?<population>\d+)[^@,\-!:>]*?!(?<attackType>[AD]{1})![^@,\-!:>]*?->(?<soldiersCount>\d+)");

            StringBuilder messageConverted = new StringBuilder();
            List<string> aPlanets = new List<string>();
            List<string> dPlanets = new List<string>();

            //Dictionary<string, List<string>> answer = new Dictionary<string, List<string>>();

            int decryptionKey = 0;

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                messageConverted = new StringBuilder();

                MatchCollection currentMatches = decryptor.Matches(input);
                decryptionKey = currentMatches.Count;

                
                foreach (char character in input)
                {
                    var currChar = (char)(character - decryptionKey);
                    messageConverted.Append(currChar.ToString());
                }

                MatchCollection result = decryptorBeta.Matches(messageConverted.ToString());
                foreach (Match item in result)
                {
                    string planetName = item.Groups["planetName"].Value;
                    int population = int.Parse(item.Groups["population"].Value);
                    string attackType = item.Groups["attackType"].Value;
                    int soldiersCount = int.Parse(item.Groups["soldiersCount"].Value);
                    if (attackType=="A")
                    {
                        aPlanets.Add(planetName);
                        
                    }
                    else
                    {
                        dPlanets.Add(planetName);
                    }
                    //Console.WriteLine($"Planet Name: {planetName}\nPopulation count: {population}\nAttack Type: {attackType}\nSoldiers Count: {soldiersCount}");
                }
                
               
            }
            aPlanets.Sort();
            dPlanets.Sort();
            Console.WriteLine($"Attacked planets: {aPlanets.Count}");
            foreach (var aplanet in aPlanets)
            {
                Console.WriteLine($"-> {aplanet}");
            }

            Console.WriteLine($"Destroyed planets: {dPlanets.Count}");
            foreach (var dplanet in dPlanets)
            {
                Console.WriteLine($"-> {dplanet}");
            }


        }
    }
}
