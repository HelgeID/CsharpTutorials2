//анонімні типи (сильне посилання на екземпляр класу)
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
            var ins = new { My = new MyClass() };
            ins.My.field = 100;
            ins.My.Method();//100

            Console.ReadKey();
        }
    }
}
