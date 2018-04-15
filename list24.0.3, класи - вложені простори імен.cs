//класи - вложені простори імен

namespace namesA
{
    namespace namesB
    {
        namespace namesC
        {
            //MyClass
            class MyClass
            {
                public MyClass()
                {
                    System.Console.WriteLine(this.GetType().Name);
                }
            }
        }
    }
}

namespace MyNamespace
{
    using namesA.namesB.namesC;

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            System.Console.ReadKey();
        }
    }
}
