//класи - простір імен (видимість)

namespace NamesA
{
    namespace NamesB
    {
        class MyClass { } //однойменний стереотип

        class MyClassB
        {
            MyClass my1;
            NamesA.MyClass my2; //пряма видимість відсутня
            MyClassA my3; //пряма видимість є
        }
    }

    class MyClass { } //однойменний стереотип
    class MyClassA { }
}

namespace ConsoleApplication
{
    using NamesA;
    using NamesA.NamesB;

    class Program
    {
        static void Main()
        {
            System.Console.ReadKey();
        }
    }
}
