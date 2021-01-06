using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingClassesObjects
{
    class TrainingTeamWork
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < n; i++)
            {
                string[] inputTeams = Console.ReadLine().Split('-');
                string creator = inputTeams[0];
                string teamName = inputTeams[1];

                bool isTeamNameExist = teams.Select(t => t.TeamName).Contains(teamName);
                bool isCreatorExist = teams.Any(c => c.Creator == creator);

                if (isTeamNameExist == false && isCreatorExist == false)
                {
                    Teams team = new Teams(teamName, creator);
                    teams.Add(team);

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

            string inputJoin = Console.ReadLine();
            while (inputJoin != "end of assignment")
            {
                string[] inputMembers = inputJoin.Split("->");
                string member = inputMembers[0];
                string memberTeam = inputMembers[1];

                bool isTeamExist = teams.Any(x => x.TeamName == memberTeam);

                bool isAlreadyCreator = teams.Any(x => x.Creator == member);

                bool isAlreadyMember = teams.Any(x => x.Members.Contains(member));

                if (isTeamExist && isAlreadyCreator == false && isAlreadyMember == false)
                {
                    int indexOfTeam = teams.FindIndex(t => t.TeamName == memberTeam);

                    teams[indexOfTeam].Members.Add(member);
                }
                else if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {memberTeam} does not exist!");
                }
                else if (isAlreadyMember || isAlreadyCreator)
                {
                    Console.WriteLine($"Member {member} cannot join team {memberTeam}!");
                }

                inputJoin = Console.ReadLine();
            }

            List<Teams> teamWithMembers = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();

            List<Teams> teamWithOutMembers = teams.Where(m => m.Members.Count == 0).OrderBy(t => t.TeamName).ToList();

            foreach (var team in teamWithMembers)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- " + team.Creator);

                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(m => "-- " + m)));
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamWithOutMembers)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    class Teams
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Teams(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
    }
}
