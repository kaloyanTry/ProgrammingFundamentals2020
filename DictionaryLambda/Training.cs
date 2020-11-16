using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingAssociative
{
    class Training
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            Dictionary<string, int> students = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "exam finished")
            {
                string[] inputData = input.Split("-");
                string username = inputData[0];

                if (inputData[1] != "banned")
                {
                    string language = inputData[1];
                    int points = int.Parse(inputData[2]);

                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, 0);

                    }

                    if (points > students[username])
                    {
                        students[username] = points;
                    }

                    if (!submissions.ContainsKey(language))                   
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;
                }
                else
                {
                    if (students.ContainsKey(username))
                    {
                        students.Remove(username);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var stu in students.OrderByDescending(s => s.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{stu.Key} | {stu.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var lang in submissions.OrderByDescending(l => l.Value).ThenBy(s => s.Key))
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}