//LINQ, вираз запиту (використання викликів статичних методів)
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartData { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //база даних
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Ivan", LastName ="Ivanov", Salary = 100, StartData = DateTime.Parse("1/10/1999")},
                new Employee { FirstName = "Petr", LastName ="Petrov", Salary = 150, StartData = DateTime.Parse("10/3/2000")},
                new Employee { FirstName = "Andrev", LastName ="Andreev", Salary = 180, StartData = DateTime.Parse("5/12/1998")}
            };

            //вираз запиту
            var query = //змінна запиту
                Enumerable.Select(
                Enumerable.OrderBy(
                Enumerable.OrderBy(
                Enumerable.Where(
                employees, emp => emp.Salary >= 150),
                emp => emp.LastName),
                emp => emp.FirstName),
                emp => new { LastName = emp.LastName, FirstName = emp.FirstName });

            Console.WriteLine("Well-paid employees:");
            foreach (var item in query)
            {
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);
            }
            Console.ReadKey();
        }
    }
}
