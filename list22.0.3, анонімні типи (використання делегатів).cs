//анонімні типи (використання делегатів)
using System;

namespace ConsoleApplication
{
    delegate void MyDelegate(string @string);
    class Program
    {
        static void Main()
        {
            var ins = new
            {
                MyDel = new MyDelegate((string @string) => Console.WriteLine(@string))
            };

            ins.MyDel("Hello, World!");
            Console.ReadKey();
        }
    }
}
