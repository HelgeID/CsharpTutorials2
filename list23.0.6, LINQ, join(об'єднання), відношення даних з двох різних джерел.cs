//LINQ, join(об'єднання), відношення даних з двох різних джерел
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class EmployeeName
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeNationality
    {
        public string Id { get; set; }
        public string Nationality { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var empName = new List<EmployeeName>
            {
                new EmployeeName { Id = "111", Name = "Ivan Ivanov" },
                new EmployeeName { Id = "222", Name = "Andrey Andreev" },
                new EmployeeName { Id = "333", Name = "Petr Petrov" },
                new EmployeeName { Id = "444", Name = "Alex Alexeev" }
            };

            var empNationality = new List<EmployeeNationality>
            {
                new EmployeeNationality { Id = "111", Nationality = "ru" },
                new EmployeeNationality { Id = "222", Nationality = "ua" },
                new EmployeeNationality { Id = "333", Nationality = "en" }
            };

            //будуємо запит та створюємо список
            var query = from emp in empName
                        join n in empNationality
                        on emp.Id equals n.Id //додатковий фільтр (в даному прикладі вказуємо, що рівні ID)
                        orderby n.Nationality ascending //ascending - за зростанням, descending - за спаданням (Nationality)
                        select new //повертає колекію анонімного типу
                        {
                            Id = emp.Id,
                            Name = emp.Name,
                            Nationality = n.Nationality
                        };

            foreach (var person in query)
                Console.WriteLine("{0}, {1}, \t{2}", person.Id, person.Name, person.Nationality);

            Console.ReadKey();
        }
    }
}
