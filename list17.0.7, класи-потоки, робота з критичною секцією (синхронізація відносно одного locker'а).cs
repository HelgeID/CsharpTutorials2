//класи, потоки, робота з критичною секцією (синхронізація відносно одного locker'а)
using System;
using System.Threading;

namespace ConsoleApplication
{
    class Program
    {
        //критичні секції в різних місцях, але об'єкт блокування locker - один
        static object locker = new object();

        static void WriteSecond()
        {
            //Stream Secondary
            for (int counter = 0; counter < 20; counter++)
            {
                lock (locker)
                {
                    //критична секція Secondary
                    Console.WriteLine("Stream Secondary: step {0}", counter);
                    Thread.Sleep(100);
                }
            }
        }

        static void Main(string[] args)
        {
            ThreadStart WriteSecond = new ThreadStart(Program.WriteSecond);
            Thread thread = new Thread(Program.WriteSecond);
            thread.Start();

            //Stream Primary
            for (int counter = 0; counter < 20; counter++)
            {
                lock (locker)
                {
                    //критична секція Primary
                    Console.WriteLine("Stream Primary: step {0}", counter);
                    Thread.Sleep(100);
                }
            }
            Console.ReadKey();
        }
    }
}
