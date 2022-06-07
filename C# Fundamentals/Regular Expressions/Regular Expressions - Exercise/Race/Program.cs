using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string inputBeta = Console.ReadLine();
            var result = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                result.Add(input[i], 0);
            }
            Regex nameRegex = new Regex(@"(?<name>[A-Za-z]+)");
            Regex numRegex = new Regex(@"(?<number>\d)");
            string nameConcat = string.Empty;
            int numResult = 0;
            while (inputBeta != "end of race")
            {


                MatchCollection matchName = nameRegex.Matches(inputBeta);
                MatchCollection matchNumbers = numRegex.Matches(inputBeta);

                for (int i = 0; i < matchName.Count; i++)
                {
                    nameConcat += matchName[i];
                }
                if (result.ContainsKey(nameConcat))
                {

                    for (int i = 0; i < matchNumbers.Count; i++)
                    {
                        numResult += int.Parse(matchNumbers[i].ToString());
                    }
                    result[nameConcat] += numResult;
                }


                nameConcat = string.Empty;
                numResult = 0;
                inputBeta = Console.ReadLine();


            }
            int counter = 1;

            var finalResult = result.OrderByDescending(x => x.Value);


            //StringBuilder printThis = new StringBuilder();


            foreach (var item in finalResult)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"{counter}st place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"{counter}nd place: {item.Key}");
                }
                else
                {
                    Console.WriteLine($"{counter}rd place: {item.Key}");
                    return;
                }
                counter++;
                //if (counter==3)
                //{
                //    Console.WriteLine($"{counter}rd place: {item.Key}");
                //    return;
                //}
            }

        }
    }
}
