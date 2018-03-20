//колекції (оператор yield)

//Program.cs
using System;
using System.Collections;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            //v1 
            foreach (string element in UserCollection.Power())
                Console.WriteLine(element);
            Console.WriteLine(new string('-', 10));



            //v2 (так працює foreach)
            IEnumerable enumerable = UserCollection.Power();
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                String element = enumerator.Current as String;
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
