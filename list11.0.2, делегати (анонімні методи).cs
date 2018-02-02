//делегати (анонімні методи)

//приклад1
using System;

namespace Delegates
{
    delegate void MyDelegate(string str);

    class Program
    {
        public static void MyMethod(string str)
        {
            Console.WriteLine(str);
        }

        static void Main()
        {
            //анонімний метод
            MyDelegate myDelegate1 = new MyDelegate(delegate (string str) { Console.WriteLine(str); });
            myDelegate1.Invoke("Hello 1");//Hello 1

            //вказуємо метод
            MyDelegate myDelegate2 = new MyDelegate(MyMethod);
            myDelegate2.Invoke("Hello 2");//Hello 2

            Console.ReadKey();
        }
    }
}



//приклад2
using System;

namespace Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate1 = delegate { Console.WriteLine("Hello, World!"); };
            //виклик анонімного метода
            myDelegate1();//Hello, World!

            MyDelegate myDelegate2 = new MyDelegate(delegate { Console.WriteLine("Hello, World!"); });
            //виклик анонімного метода
            myDelegate2();//Hello, World!

            Console.ReadKey();
        }
    }
}



//приклад3
//анонімний метод (з аргументом) повертає значення
using System;

namespace Delegates
{
    public delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main()
        {
            int arg1 = 10, arg2 = 20;
            MyDelegate myDelegate = delegate (int a, int b) { return a + b; };
            Console.WriteLine(myDelegate(arg1, arg2));//30
            Console.ReadKey();
        }
    }
}



//приклад3
//анонімний метод (з аргументом ref, out)
using System;

namespace Delegates
{
    public delegate void MyDelegate(ref int a, ref int b, out int c);

    class Program
    {
        static void Main()
        {
            int arg1 = 1, arg2 = 2, res = 0;
            MyDelegate myDelegate = delegate (ref int a, ref int b, out int c) { a *= 10; b *= 10; c = a + b; };
            myDelegate(ref arg1, ref arg2, out res);
            Console.WriteLine(res);//30
            Console.ReadKey();
        }
    }
}




//приклад4
using System;

namespace Delegates
{
    delegate void Delegate();
    class Program
    {
        public static void MyMethod1()
        {
            Console.WriteLine("Call Method 1");
        }

        public static void MyMethod2()
        {
            Console.WriteLine("Call Method 2");
        }

        static void Main()
        {
            Delegate myDelegate;
            myDelegate = new Delegate(MyMethod1);
            myDelegate.Invoke();//Call Method 1
            myDelegate = new Delegate(MyMethod2);
            myDelegate.Invoke();//Call Method 2

            Console.ReadKey();
        }
    }
}
