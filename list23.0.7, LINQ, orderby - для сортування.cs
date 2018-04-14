//LINQ, orderby - для сортування
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
                new Employee { LastName = "Ivanov", FirstName = "Ivan", Nationality = "ru" },
                new Employee { LastName = "Andreev", FirstName = "Andrew", Nationality = "uk" },
                new Employee { LastName = "Petrov", FirstName = "Petr", Nationality = "en" }
            };

            //будуємо запит та створюємо список
            var query = from emp in employees
                        orderby emp.Nationality ascending,
                        emp.LastName descending, //ascending - за зростанням, descending - за спаданням (Nationality)
                        emp.FirstName descending //ascending - по замовчуванню
                        select emp;

            foreach (var person in query)
                Console.WriteLine("{0}, {1}, {2}", person.LastName, person.FirstName, person.Nationality);

            Console.ReadKey();
        }
    }
}
