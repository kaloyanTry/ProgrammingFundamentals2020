using System;
using System.Linq;
using System.Collections.Generic;

namespace Students4
{
    class StudentsGrades
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var studentInfo = Console.ReadLine().Split(' ').ToArray();

                Student student = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));

                students.Add(student);
            }

            Console.WriteLine(String.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade)));
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
