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
                string teamName = inputData[1];

                bool isTeamNameExist = allTeams.Select(x => x.TeamName).Contains(teamName);

                bool isCreatorExist = allTeams.Any(x => x.Creator == creator);

                if (isTeamNameExist == false && isCreatorExist == false)
                {
                    Team currentTeam = new Team(teamName, creator);

                    allTeams.Add(currentTeam);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
                else if (isTeamNameExist)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
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

                string member = matesData[0];
                string ofMemberTeam = matesData[1];

                bool isTeamExist = allTeams.Any(x => x.TeamName == ofMemberTeam);

                bool isCreatorCheating = allTeams.Any(x => x.Creator == member);
                bool isAlreadyFen = allTeams.Any(x => x.Members.Contains(member));

                if (isTeamExist && isCreatorCheating == false && isAlreadyFen == false)
                {
                    int indexOfTeam = allTeams.FindIndex(x => x.TeamName == ofMemberTeam);

                    allTeams[indexOfTeam].Members.Add(member);
                }
                else if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {ofMemberTeam} does not exist!");
                }
                else if (isAlreadyFen || isCreatorCheating)
                {
                    Console.WriteLine($"Member {member} cannot join team {ofMemberTeam}!");
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
