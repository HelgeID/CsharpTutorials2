//класи, потоки (виклик одного і того ж метода різними потоками)
using System;
using System.Threading;

namespace ConsoleApplication
{
    class Program
    {
        static void WriteSecond()
        {
            int counter = 0;

            while (counter < 10) {
                Thread.Sleep(500);
                Console.WriteLine("Thread ID {0}, counter = {1}", Thread.CurrentThread.GetHashCode(), counter);
                counter++;
            }
        }

        static void Main(string[] args)
        {
            //робота з вторинним потоком
            Thread thread = new Thread(WriteSecond);
            thread.Start();//виклик метода WriteSecond асинхронно

            //робота з первинним потоком
            WriteSecond();//виклик метода WriteSecond синхронно

            Console.ReadKey();
        }
    }
}
