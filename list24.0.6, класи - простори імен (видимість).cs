//класи - простори імен (видимість)
using System;

namespace namesA
{
    namespace namesB
    {
        namespace namesC
        {
            class MyClassC
            {
                MyClassA myA = new MyClassA(); //ok
                MyClassB myB = new MyClassB(); //ok
                MyClassC myC = new MyClassC(); //ok
            }
        }
        class MyClassB
        {
            MyClassA myA = new MyClassA(); //ok
            MyClassB myB = new MyClassB(); //ok
            //MyClassC myC = new MyClassC(); //недоступний
        }
    }
    class MyClassA
    {
        MyClassA myA = new MyClassA(); //ok
        //MyClassB myB = new MyClassB(); //недоступний
        //MyClassC myC = new MyClassC(); //недоступний
    }
}

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            Console.ReadKey();
        }
    }
}
