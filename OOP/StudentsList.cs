using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsOverwrite
{
    class StudentsList
    {
        static void Main(string[] args)
        {
            var listOfStudents = new List<Student>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArrguments = command.Split();
                string firstName = commandArrguments[0];
                string lastName = commandArrguments[1];
                string age = commandArrguments[2];
                string city = commandArrguments[3];

                Student student = listOfStudents
                    .FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

                if (student != null)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                else
                {
                    student = new Student();
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                    listOfStudents.Add(student);
                }
                command = Console.ReadLine();
            }

            string filteredCity = Console.ReadLine();
            List<Student> FilteredStudent = listOfStudents.Where(s => s.City == filteredCity).ToList();
            foreach (var student in FilteredStudent)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
    class Student
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
    }
}
