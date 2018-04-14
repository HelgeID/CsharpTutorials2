//LINQ, ідентифікатор let (приклад конкатинації рядків)
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee { LastName = "Ivanov", FirstName = "Ivan" },
                new Employee { LastName = "Andreev", FirstName = "Andrew" },
                new Employee { LastName = "Petrov", FirstName = "Petr" }
            };

            //будуємо запит
            var query = from emp in employees
                        let fullName = emp.FirstName + " " + emp.LastName // let -новий локальний ідентифікатор
                        orderby fullName descending
                        select fullName;

            foreach (var person in query)
                Console.WriteLine(person);

            Console.ReadKey();
        }
    }
}


//приклад 2 (таблиця множення)
/*
            var query = from x in Enumerable.Range(0, 10)
                        let innerRange = Enumerable.Range(0, 10)
                        from y in innerRange
                        select new { X = x, Y = y, Product = x * y };

            foreach (var item in query)
                Console.WriteLine("{0} * {1} = {2}", item.X, item.Y, item.Product);
 */
