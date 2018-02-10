//класи, потоки, робота з критичною секцією (послідовність виконання потоків відносно locker'а)
using System;
using System.Threading;

namespace ConsoleApplication
{
    class MyClass
    {
        object block = new object();//об'єкт синхронізації доступу до розділяючого ресурсу (об'єкт блокування)

        public void Method()
        {
            //получаємо хеш поточного потока
            int hash = Thread.CurrentThread.GetHashCode();

            lock (block)//потоки чекають на один одного
            {
                //критична секція для розділяючого ресурсу
                for (int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine("Stream #{0}: step {1}", hash, counter);
                    Thread.Sleep(100);
                }
                Console.WriteLine(new string('-', 20));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            MyClass ins = new MyClass();
            for (int i = 0; i < 3; i++)
            {
                new Thread(ins.Method).Start();
            }
            Thread.Sleep(500);

            Console.ReadKey();
        }
    }
}

/* v1 безпечний
lock (block)
{
    ...
}
*/

/* v2 - небезпечний (можлива мертва петля для потока)
Monitor.Enter(block);
    ...
Monitor.Exit(block);
*/
