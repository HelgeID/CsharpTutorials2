//базовий клас Object (метод GetType())
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Object obj = new Object();
            Type type = obj.GetType();
            Console.WriteLine(type.ToString());//System.Object
            Console.ReadKey();
        }
    }
}
