//класи - доступ між просторами імен

namespace MyNames
{
    namespace NamesA
    {
        class MyClassA
        {
            //без інпорта простора імен неможливо реалізувати
            //MyClassB my = new MyClassB(); //error
        }
    }

    namespace NamesB
    {
        class MyClassB
        {
            //без інпорта простора імен неможливо реалізувати
            //MyClassA my = new MyClassA(); //error
        }
    }
}

namespace ConsoleApplication
{
    using MyNames.NamesA;
    using MyNames.NamesB;

    class Program
    {
        static void Main()
        {
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();

            System.Console.ReadKey();
        }
    }
}
