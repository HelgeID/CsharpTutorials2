//простори імен, повторне створення вложеного простору імен

namespace namesA
{
    namespace namesB
    {
        namespace namesC
        {
            class MyClassC
            {
                MyClassA myA = new MyClassA();
                MyClassB myB = new MyClassB();
                MyClassB2 myB2 = new MyClassB2();
            }
        }
        class MyClassB { }
    }
    class MyClassA { }
}

//розширення namespace namesB
namespace namesA.namesB
{
    class MyClassB2 { }
}

namespace ConsoleApplication
{
    using namesA.namesB.namesC;

    class Program
    {
        static void Main()
        {
            MyClassC myC = new MyClassC();
            System.Console.ReadKey();
        }
    }
}
