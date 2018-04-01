//LINQ, вираз запиту
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
                        from employee in employees //from - оголошує змінну діапазона employee
                        where employee.Salary >= 150 //where - фільтр
                        orderby employee.LastName, employee.FirstName //упорядкування (спочатку фамілія, потім ім'я)
                        select new //select - операція проекції
                        {
                            LastName = employee.LastName,
                            FirstName = employee.FirstName
                        };
            Console.WriteLine("Well-paid employees:");
            foreach (var item in query)
            {
                Console.WriteLine("{0} {1}", item.LastName, item.FirstName);
            }
            /*
            Well-paid employees:
            Andreev Andrev
            Petrov Petr
            
             */
            Console.ReadKey();
        }
    }
}
