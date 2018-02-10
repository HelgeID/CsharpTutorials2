//класи, потоки (передача параметрів, групи параметрів)
using System;
using System.Threading;

namespace ConsoleApplication
{
    class Box
    {
        public string el1 = "Hello!";
        public int el2 = 100;
    }

    class Program
    {
        static void WriteBox(object argument)
        {
            Box box = (Box)argument;
            Console.WriteLine(box.el1);
            Console.WriteLine(box.el2);
        }

        static void WriteSecond(object argument)
        {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(argument);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            ParameterizedThreadStart writeBox = new ParameterizedThreadStart(WriteBox);
            Thread threadBox = new Thread(writeBox);
            threadBox.Start(new Box());//передача Box, групи параметрів

            Thread.Sleep(1000);//робимо затримку 1с

            ParameterizedThreadStart writeSecond = new ParameterizedThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            thread.Start("Hi!");//передаа параметра "Hi!"

            Console.ReadKey();
        }
    }
}
