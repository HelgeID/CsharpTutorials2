//класи - вложені простори імен (інпорт)

//v1
//using namesA;
//using namesA.namesB;
//using namesA.namesB.namesC;

namespace namesA
{
    namespace namesB
    {
        namespace namesC
        {
            class MyClassC { }
        }

        class MyClassB { }
    }

    class MyClassA { }
}

namespace MyNamespace
{
    //v2
    using namesA;
    using namesA.namesB;
    using namesA.namesB.namesC;
    class Program
    {
        static void Main()
        {
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
            MyClassC myC = new MyClassC();

            System.Console.ReadKey();
        }
    }
}
