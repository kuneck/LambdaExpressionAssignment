using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees with at least 10 employees, including two with the first name "Joe".
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Logan", LastName = "Howlett" }, // Wolverine
                new Employee { Id = 2, FirstName = "Jean", LastName = "Grey" }, // Jean Grey
                new Employee { Id = 3, FirstName = "Scott", LastName = "Summers" }, // Cyclops
                new Employee { Id = 4, FirstName = "Ororo", LastName = "Munroe" }, // Storm
                new Employee { Id = 5, FirstName = "Kurt", LastName = "Wagner" }, // Nightcrawler
                new Employee { Id = 6, FirstName = "Charles", LastName = "Xavier" }, // Professor X
                new Employee { Id = 7, FirstName = "Hank", LastName = "McCoy" }, // Beast
                new Employee { Id = 8, FirstName = "Anna", LastName = "Marie" }, // Rogue
                new Employee { Id = 9, FirstName = "Joe", LastName = "Daken" }, // Daken
                new Employee { Id = 10, FirstName = "Joe", LastName = "Fixit" } // Joe Fixit (Hulk)
            };

            // Use a foreach loop to create a new list of all employees with the first name "Joe".
            List<Employee> joes1 = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joes1.Add(emp);
                }
            }

            // Display the list of employees named Joe created by the foreach loop
            Console.WriteLine("Employees named Joe (using foreach):");
            foreach (Employee joe in joes1)
            {
                Console.WriteLine("ID: " + joe.Id + ", Name: " + joe.FirstName + " " + joe.LastName);
            }

            // Use a lambda expression to create a new list of all employees with the first name "Joe".
            List<Employee> joes2 = employees.Where(e => e.FirstName == "Joe").ToList();

            // Display the list of employees named Joe created by the lambda expression
            Console.WriteLine("\nEmployees named Joe (using lambda):");
            foreach (Employee joe in joes2)
            {
                Console.WriteLine("ID: " + joe.Id + ", Name: " + joe.FirstName + " " + joe.LastName);
            }

            // Use a lambda expression to create a list of all employees with an ID greater than 5.
            List<Employee> idGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            // Display the list of employees with ID greater than 5 created by the lambda expression
            Console.WriteLine("\nEmployees with ID greater than 5:");
            foreach (Employee emp in idGreaterThan5)
            {
                Console.WriteLine("ID: " + emp.Id + ", Name: " + emp.FirstName + " " + emp.LastName);
                Console.ReadLine();
            }
        }
    }
}
