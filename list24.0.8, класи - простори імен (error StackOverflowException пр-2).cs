//класи - простори імен (error StackOverflowException)
using System;

using namesA;
using namesA.namesB;
using namesA.namesB.namesC;

namespace namesA
{
    namespace namesB
    {
        namespace namesC
        {
            class MyClassC
            {
                MyClassA myA = new MyClassA(); //StackOverflowException 3
                MyClassB myB = new MyClassB(); //StackOverflowException 6
                MyClassC myC = new MyClassC(); //StackOverflowException 7
            }
        }
        class MyClassB
        {
            MyClassA myA = new MyClassA(); //StackOverflowException 4
            MyClassB myB = new MyClassB(); //StackOverflowException 5
            MyClassC myC = new MyClassC();
        }
    }
    class MyClassA
    {
        MyClassA myA = new MyClassA(); //StackOverflowException 1
        MyClassB myB = new MyClassB(); //StackOverflowException 2
        MyClassC myC = new MyClassC();
    }
}

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            //видимі тому, що add (using namesA; using namesA.namesB; using namesA.namesB.namesC;)
            MyClassA myA = new MyClassA();
            MyClassB myB = new MyClassB();
            MyClassC myC = new MyClassC();

            Console.ReadKey();
        }
    }
}
