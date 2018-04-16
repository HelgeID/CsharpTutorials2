//класи - простори імен (error StackOverflowException)

namespace namesA
{
    class MyClassA
    {
        MyClassA my;

        public MyClassA()
        {
            System.Console.WriteLine("Constructor MyClassA");

            //рефлексивна самоасоціація
            my = new MyClassA();
        }
    }
}

namespace ConsoleApplication
{
    using namesA;

    class Program
    {
        static void Main()
        {
            MyClassA myA = new MyClassA();
            System.Console.ReadKey();
        }
    }
}
