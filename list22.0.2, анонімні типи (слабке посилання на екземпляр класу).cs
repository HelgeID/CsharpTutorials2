//анонімні типи (слабке посилання на екземпляр класу)
using System;

namespace ConsoleApplication
{
    class MyClass
    {
        public int field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main()
        {
            new
            {
                My = new MyClass { field = 100 }
            }.My.Method();//100

            Console.ReadKey();
        }
    }
}
