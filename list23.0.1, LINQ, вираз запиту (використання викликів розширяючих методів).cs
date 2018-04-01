//LINQ, вираз запиту (використання викликів розширяючих методів)
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
                        employees //трансформація в послідовність розширяючих методів
                        .Where(emp => emp.Salary >= 150)
                        .OrderBy(emp => emp.LastName)
                        .OrderBy(emp => emp.FirstName)
                        .Select(emp => new
                        {
                            LastName = emp.LastName,
                            FirstName = emp.FirstName
                        });

            Console.WriteLine("Well-paid employees:");
            foreach (var item in query)
            {
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);
            }
            Console.ReadKey();
        }
    }
}
