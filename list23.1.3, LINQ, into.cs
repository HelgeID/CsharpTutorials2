//LINQ, into
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //збудувати запит
            var query = from x in numbers
                        group x by x % 2 into partition //перевірка на парність та запис в змінну partition
                        //where partition.Key == 0 //фільтр для груп
                        select new { Key = partition.Key, Count = partition.Count(), Groupe = partition };

            foreach (var item in query)
            {
                Console.WriteLine("mod2 == {0}", item.Key);
                Console.WriteLine("Count == {0}", item.Count);

                foreach (var number in item.Groupe)
                    Console.Write("{0}, ", number);

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
