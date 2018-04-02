//LINQ, можливість розширення та власна реалізація Where, Select
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public static class MySet
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            Console.WriteLine("Where");
            return System.Linq.Enumerable.Where(source, predicate);//повертання колекції
        }

        public static IEnumerable<R> Select<T, R>(this IEnumerable<T> source, Func<T, R> selector)
        {
            Console.WriteLine("Select");
            return System.Linq.Enumerable.Select(source, selector);//повертання колекції
        }
    }

    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var query = from x in numbers
                        where x % 2 == 0
                        select x * 2;

            foreach (var item in query)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
