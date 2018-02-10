//класи, потоки
using System;
using System.Threading;

namespace ConsoleApplication
{
    class Program
    {
        //вторинний поток
        static void WriteSecond()
        {
            while (true) {
                Console.WriteLine(new string(' ', 10) + "Secondary");
            }
        }

        static void Main(string[] args)
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);//writeSecond - делегат, для того, щоб метод WriteSecond виконувався паралельно
            Thread thread = new Thread(writeSecond);//створюємо обєктне-орієнтоване представлення окремого потока
            thread.Start();

            //первинний поток
            while (true) {
                Console.WriteLine("Primary");
            }

            Console.ReadKey();
        }
    }
}
