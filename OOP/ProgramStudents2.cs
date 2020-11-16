using System;
using System.Collections.Generic;
using System.Linq;

namespace Students2._0
{
    class ProgramStudents2
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (student != null)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    student = new Student(firstName, lastName, age, homeTown);
                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            string criteria = Console.ReadLine();

            List<Student> filteredStudents = students.Where(t => t.HomeTown == criteria).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, filteredStudents));
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}