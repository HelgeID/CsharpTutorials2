//LINQ, group - як розділення запиту
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

            //будуємо запит
            var query = from x in numbers
                        group x by x % 3;//group позволяє розгрупувати числа
            foreach (var group in query)
            {
                Console.WriteLine("mod{0} == {0}", group.Key); //group.Key, значення ключа - тут друга колекція

                foreach (var number in group) //по значенням ключів лежать номера
                    Console.WriteLine("{0}, ", number);
            }

            Console.ReadKey();
        }
    }
}
