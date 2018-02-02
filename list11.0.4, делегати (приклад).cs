//делегати (приклад)
using System;

namespace Delegates
{
    static class MyClass
    {
        public static void Method(string str)
        {
            Console.WriteLine(str);
        }
    }

    public delegate void MyDelegate(string str);

    class Program
    {
        static void Main()
        {
            //v1
            MyDelegate myDelegate1 = new MyDelegate(MyClass.Method);
            myDelegate1("Hello 1");//Hello 1

            //v2
            MyDelegate myDelegate2 = MyClass.Method;
            myDelegate2("Hello 2");//Hello 2

            Console.ReadKey();
        }
    }
}
