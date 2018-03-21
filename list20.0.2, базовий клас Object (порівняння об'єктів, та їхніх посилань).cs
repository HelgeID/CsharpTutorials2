//базовий клас Object (порівняння об'єктів, та їхніх посилань)
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Object obj1 = new Object();
            Object obj2 = new Object();

            //Різні хеш-коди
            Console.WriteLine(obj1.Equals(obj2));//False
            Console.WriteLine(ReferenceEquals(obj1, obj2));//False
            Console.WriteLine(Equals(obj1, obj2));//False

            obj1 = obj2;
            Console.WriteLine(obj1.Equals(obj2));//True
            Console.WriteLine(ReferenceEquals(obj1, obj2));//True
            Console.WriteLine(Equals(obj1, obj2));//True

            Console.ReadKey();
        }
    }
}
