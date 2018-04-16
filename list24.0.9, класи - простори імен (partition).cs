//класи - простори імен (partition)

namespace MyNames
{
    class MyClass { }
}

namespace MyNames
{
    //class MyClass { } //error
}

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            MyNames.MyClass my = new MyNames.MyClass();

            System.Console.ReadKey();
        }
    }
}
