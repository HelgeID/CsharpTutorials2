//класи - однойменні простори імен (колізія між класами)

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
    using MyNames;
    using MyNames.MyNames;

    class Program
    {
        static void Main()
        {
            //екземпляр класа без повної кваліфікації імені
            //MyClass my = new MyClass();//error

            //повна кваліфікація імені
            MyNames.MyClass my1 = new MyNames.MyClass();
            MyNames.MyNames.MyClass my2 = new MyNames.MyNames.MyClass();

            System.Console.ReadKey();
        }
    }
}
