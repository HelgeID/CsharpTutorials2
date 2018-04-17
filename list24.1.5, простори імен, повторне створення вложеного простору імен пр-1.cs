//простори імен, повторне створення вложеного простору імен

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

namespace namesA.namesB.namesC
{
    //class MyClassC2 { }

    class MyClassC2
    {
        MyClassA myA = new MyClassA();
        MyClassB myB = new MyClassB();
        MyClassC myC = new MyClassC();
    }
}

namespace ConsoleApplication
{
    using namesA.namesB.namesC;

    class Program
    {
        static void Main()
        {
            MyClassC myC = new MyClassC();
            MyClassC2 myC2 = new MyClassC2();

            System.Console.ReadKey();
        }
    }
}
