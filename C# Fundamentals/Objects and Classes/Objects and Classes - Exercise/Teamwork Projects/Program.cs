using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                string currTeamName = input[1];
                string currCreator = input[0];

                Team currTeam = new Team(currTeamName, currCreator, currCreator);
                if (IsTeamNameFree(teams, currTeamName))
                {
                    teams.Add(currTeam);

                    Console.WriteLine($"Team {currTeamName} has been created by {currCreator}!");
                }
                else
                {
                    if (IsUserOwnerOfATeam(teams, currCreator))
                    {
                        Console.WriteLine($"{currCreator} cannot create another team!");
                        input = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }


                    Console.WriteLine($"Team {currTeamName} was already created!");
                }
            }

            string inputBeta = Console.ReadLine();
            while (inputBeta != "end of assignment")
            {
                string[] info = inputBeta.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string member = info[0];
                string teamToJoin = info[1];
                if (!(DoesTeamExist(teams, teamToJoin)))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                if (MemberExist(teams, member, teamToJoin))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                }
                else
                {





                    for (int k = 0; k < teams.Count; k++)
                    {
                        if (teams[k].TeamName == teamToJoin)
                        {
                            teams[k].Members.Add(member);
                            break;
                        }
                    }


                }
                inputBeta = Console.ReadLine();
            }
            teams = teams.OrderByDescending(x => x.Members.Count()).ThenBy(x => x.TeamName).ToList();
            foreach (var item in teams.Where(x => x.Members.Count > 1))
            {
                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.Creator}");
                foreach (var person in item.Members.Where(x => x != item.Creator).OrderBy(x => x))
                {
                    Console.WriteLine($"-- {person}");
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (var item in teams.Where(x => x.Members.Count <= 1).OrderBy(x=>x.TeamName))
            {
                Console.WriteLine($"{item.TeamName}");
            }
        }

        private static bool MemberExist(List<Team> teams, string member, string teamToJoin)
        {
            bool memeberFailedToJoin = false;
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Any(x => x.Contains(member)))
                {

                    memeberFailedToJoin = true;
                }

            }

            return memeberFailedToJoin;
        }

        private static bool IsUserOwnerOfATeam(List<Team> teams, string currCreator)
        {

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Creator == currCreator)
                {
                    return true;
                }

            }
            return false;
        }

        private static bool DoesTeamExist(List<Team> teams, string teamToJoin)
        {

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].TeamName == teamToJoin)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsTeamNameFree(List<Team> teams, string currTeamName)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].TeamName == currTeamName)
                {
                    return false;
                }

            }
            return true;
        }
    }

    class Team
    {
        public Team(string teamName, string creator, string member)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>() { member };
        }


        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }



    }
}
