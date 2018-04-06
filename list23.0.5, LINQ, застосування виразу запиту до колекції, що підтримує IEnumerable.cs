//LINQ, застосування виразу запиту до колекції, що підтримує IEnumerable
using System;
using System.Collections;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);
            //явне вказання типа Int32 змінній діапазону n
            //var - неможливо так, як IEnumerable - не параметризований
            var query = from int n in numbers
                        select n * 2;//select - операція проекції
            foreach (var item in query)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}

/*
    використання анонімних типів
    ...
    select new { Digit = n * 2 };

    ...
    item.Digit
 */
