//LINQ, group(приклад групування)
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Nationality { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee { LastName = "Andreev", FirstName = "Andrew", Nationality = "uk" },
                new Employee { LastName = "Ivanov", FirstName = "Ivan", Nationality = "ru" },
                new Employee { LastName = "Andreev", FirstName = "Ivan", Nationality = "uk" },
                new Employee { LastName = "Petrov", FirstName = "Petr", Nationality = "en" },
                new Employee { LastName = "Andreev", FirstName = "Sergey", Nationality = "uk" },
                new Employee { LastName = "Petrov", FirstName = "Slava", Nationality = "en" }
            };

            //будуємо запит
            var query = from emp in employees
                        group emp by new { Nationality = emp.Nationality, LastName = emp.LastName };

            foreach (var group in query)
            {
                Console.WriteLine(group.Key);

                foreach (var employee in group)
                    Console.WriteLine(employee.FirstName);
            }

            Console.ReadKey();
        }
    }
}
