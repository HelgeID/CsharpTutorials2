//класи, потоки (приклад запуску потоків)
using System;
using System.Threading;

namespace ConsoleApplication
{
    class Program
    {
        static void WriteSecond()
        {
            Thread thread = Thread.CurrentThread;//повертає посилання на екземпляр поточного потоку
            thread.Name = "Secondary";//присвоюємо імя потоку
            //виводимо інформацію про поточний поток
            Console.WriteLine("ID {0}: {1}", thread.Name, thread.GetHashCode());

            //робота поточного потоку
            for (int counter = 0; counter < 10; counter++) {
                Console.WriteLine(new string(' ', 10) + thread.Name + " " + counter);
                Thread.Sleep(1000);//призупиняємо виконання поточного потоку
            }
        }

        static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;//получаємо посилання на екземпляр поточного потоку
            primaryThread.Name = "Primary";//присвоюємо імя потоку
            //виводимо інформацію про поточний поток
            Console.WriteLine("ID {0}: {1}", primaryThread.Name, primaryThread.GetHashCode());

            //робота вторинного потока
            Thread secondaryThread = new Thread(WriteSecond);
            secondaryThread.Start();

            //робота первинного потока
            for (int counter = 0; counter < 10; counter++) {
                Console.WriteLine(primaryThread.Name + " " + counter);
                Thread.Sleep(1000);//призупиняємо виконання поточного потоку
            }

            Console.ReadKey();
        }
    }
}
