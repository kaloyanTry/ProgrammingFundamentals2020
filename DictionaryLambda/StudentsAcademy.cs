using System;
using System.Collections.Generic;
using System.Linq;

namespace StuAcademy
{
    class StudentsAcademy
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>()); // create a new empty List with grades
                    studentGrades[name].Add(grade); // add a grade
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }
            Dictionary<string, double> avrResults = new Dictionary<string, double>();

            foreach (var pair in studentGrades)
            {
                //filling new Dict with the same Key and the average grades
                avrResults.Add(pair.Key, pair.Value.Average());
            }

            //filter and sort at the same line:
            foreach (var pair in avrResults.Where(st => st.Value >= 4.50).OrderByDescending(st => st.Value))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");

            }
        }
    }
}
