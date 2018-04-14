//LINQ, select - операція проекції
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Result
    {
        public Result(int input, int output)
        {
            Input = input;
            Output = output;
        }

        public int Input { get; set; }
        public int Output { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };
            var query = from x in numbers
                        select new Result(x, x * 2);

            numbers[0] = 100;

            //будуємо запит 
            //select new Result(x, x * 2); - починає працювати, коли ми звертаємось до query
            foreach (var item in query)
                Console.WriteLine("Input = {0}, \tOutput = {1}", item.Input, item.Output);

            Console.ReadKey();
        }
    }
}
