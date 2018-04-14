//LINQ, select - операція проекції
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };

            //будуємо запит (заміна класа анонімний типом)
            var query = from x in numbers
                        select new { Input = x, Output = x * 2 };

            foreach (var item in query)
                Console.WriteLine("Input = {0}, \tOutput = {1}", item.Input, item.Output);

            Console.ReadKey();
        }
    }
}
