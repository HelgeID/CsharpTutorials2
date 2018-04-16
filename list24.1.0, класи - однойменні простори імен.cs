//класи - однойменні простори імен

namespace MyNames
{
    class MyClass { }

    namespace MyNames
    {
        class MyClass { }
    }
}

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            MyNames.MyClass my1 = new MyNames.MyClass();
            MyNames.MyNames.MyClass my2 = new MyNames.MyNames.MyClass();

            System.Console.ReadKey();
        }
    }
}
