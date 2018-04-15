//класи - простор імен, псевдоніми типів

namespace namesA
{
    namespace namesB
    {
        namespace namesC
        {
            class MyClassC
            {
                public void Method()
                {
                    System.Console.WriteLine("Hello, World!");
                }
            }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

namespace MyNamespace
{
    //MyClass - це псевдонім для MyClassC
    using MyClass = namesA.namesB.namesC.MyClassC;

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
            my.Method();
            System.Console.WriteLine(my.GetType());//повертає імя MyClassC

            System.Console.ReadKey();
        }
    }
}
