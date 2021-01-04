using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> allTeams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split('-');

                string creator = inputData[0];
                string teamNeme = inputData[1];

                bool isTeamNameExist = allTeams.Select(x => x.TeamName).Contains(teamNeme);

                bool isCreatorExist = allTeams.Any(x => x.Creator == creator);

                if (isTeamNameExist == false && isCreatorExist == false)
                {
                    Team currentTeam = new Team(teamNeme, creator);

                    allTeams.Add(currentTeam);

                    Console.WriteLine("Team {0} has been created by {1}!", teamNeme, creator);
                }
                else if (isTeamNameExist)
                {
                    Console.WriteLine($"Team {teamNeme} was already created!");
                }
                else if (isCreatorExist)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }

            string inputMates = Console.ReadLine();

            while (inputMates != "end of assignment")
            {
                string[] matesData = inputMates.Split("->");

                string fen = matesData[0];
                string ofFensTeam = matesData[1];

                bool isTeamExist = allTeams.Any(x => x.TeamName == ofFensTeam);

                bool isCreatorCheating = allTeams.Any(x => x.Creator == fen);
                bool isAlreadyFen = allTeams.Any(x => x.Members.Contains(fen));

                if (isTeamExist && isCreatorCheating == false && isAlreadyFen == false)
                {
                    int indexOfTeam = allTeams.FindIndex(x => x.TeamName == ofFensTeam);

                    allTeams[indexOfTeam].Members.Add(fen);
                }
                else if (isTeamExist == false)
                {
                    Console.WriteLine("Team {0} does not exist!", ofFensTeam);
                }
                else if (isAlreadyFen || isCreatorCheating)
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", fen, ofFensTeam);
                }

                inputMates = Console.ReadLine();
            }

            List<Team> teamWithMembers = allTeams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();

            List<Team> teamNotValid = allTeams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName).ToList();

            foreach (var team in teamWithMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- " + team.Creator);

                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(m => "-- " + m)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teamNotValid)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }  
        public List<string> Members { get; set; }

        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
    }
}
