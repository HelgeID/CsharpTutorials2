//делегати, складніший приклад

//приклад1
using System;

namespace Delegates
{
    delegate Delegate2 Delegate1();//1.
    delegate void Delegate2();//2.

    class Program
    {
        public static Delegate2 Method1()//1.
        {
            return new Delegate2(Method2);
        }

        public static void Method2()//2
        {
            Console.WriteLine("Hello, World!");
        }

        static void Main()
        {
            Delegate1 delegate1 = new Delegate1(Method1);
            Delegate2 delegate2 = delegate1();
            delegate2.Invoke();

            Console.ReadKey();
        }
    }
}



//приклад2
using System;

namespace Delegates
{
    delegate Delegate3 Functional(Delegate1 delegate1, Delegate2 delegate2);
    delegate string Delegate1();
    delegate string Delegate2();
    delegate string Delegate3();

    class Program
    {
        public static Delegate3 MethodF(Delegate1 delegate1, Delegate2 delegate2)
        {
            return delegate { return delegate1.Invoke() + delegate2.Invoke(); };
        }

        public static string Method1() { return "Hello "; }
        public static string Method2() { return "World!"; }

        static void Main(string[] args)
        {
            Functional functional = new Functional(MethodF);
            Delegate3 delegate3 = functional.Invoke(new Delegate1(Method1), new Delegate2(Method2));
            Console.WriteLine(delegate3.Invoke());
            Console.ReadKey();
        }
    }
}



//приклад3
using System;

namespace Delegates
{
    delegate MyDelegate Functional(MyDelegate delegate1, MyDelegate delegate2);
    delegate string MyDelegate();

    class Program
    {
        static void Main()
        {
            MyDelegate delegate1 = () => "Hello, ", delegate2 = () => "World!";
            //v1
            Functional functional1 = delegate (MyDelegate d1, MyDelegate d2) { return delegate () { return d1.Invoke() + d2.Invoke(); }; };
            //v2
            Functional functional2 = delegate (MyDelegate d1, MyDelegate d2) { return () => d1.Invoke() + d2.Invoke(); };
            //v3
            Functional functional3 = (MyDelegate d1, MyDelegate d2) => () => d1() + d2();

            Console.WriteLine(functional1(delegate1, delegate2)());
            Console.WriteLine(functional2(delegate1, delegate2)());
            Console.WriteLine(functional3(delegate1, delegate2)());

            Console.ReadKey();
        }
    }
}
