using System;
using System.Collections.Generic;
using System.Linq;

namespace Students

{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                string age = tokens[2];
                string city = tokens[3];

                Students student = new Students()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);
                line = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            List<Students> filteredStudents = students.Where(s => s.City == filterCity).ToList();

            foreach (Students student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string City { get; set; }

    }
}
