using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main()
        {
            List<Department> departments = new List<Department>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                string name = inputData[0];
                decimal salary = decimal.Parse(inputData[1]);
                string department = inputData[2];

                if (!departments.Any(d => d.DepartmentName == department))
                {
                    departments.Add(new Department(department));
                }

                departments.Find(d => d.DepartmentName == department).AddNewEmployee(name, salary);
            }

            Department bestDepartment = departments.OrderByDescending(d => d.TotalSalaries / d.Employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

            foreach (var employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public decimal TotalSalaries { get; set; }

        public void AddNewEmployee(string empName, decimal empSalary)
        {
            TotalSalaries += empSalary;
            Employees.Add(new Employee(empName, empSalary));
        }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }
    }
}