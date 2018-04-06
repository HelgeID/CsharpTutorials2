//LINQ, приклад таблиці множення
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            //конструкція from похожа на foreach
            //використання декількох конструкцій from аналогічно вкладеним операторам foreach
            var query = from x in Enumerable.Range(1, 9)
                        from y in Enumerable.Range(1, 10)
                        select new
                        {
                            X = x, Y = y,
                            Product = x * y
                        };

            foreach (var item in query)
                Console.WriteLine("{0} * {1} = {2}", item.X, item.Y, item.Product);

            Console.ReadKey();
        }
    }
}

/*
var coll_1 = Enumerable.Range(1, 9);
var coll_2 = Enumerable.Range(1, 10);
var query = from x in coll_1
            from x in coll_2
            ...

 */
 