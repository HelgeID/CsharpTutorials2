//клонування (реалізація при допомозі MemberwiseClone() та конструктора)
using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApplication
{
    class MyClass : ICloneable
    {
        int a, b;
        public MyClass()
        {
            Thread.Sleep(1000);
            a = new Random().Next(1, 100);
            Thread.Sleep(1000);
            b = new Random().Next(1, 100);
        }

        public object Clone()
        {
            //v1
            return this.MemberwiseClone();//при допомозі MemberwiseClone()
            //v2
            //return new MyClass();//при допомозі конструктора
        }
    }
    class Program
    {
        static void Main()
        {
            Stopwatch timer = new Stopwatch();

            //за скільки часу був створений original
            timer.Start();
            MyClass original = new MyClass();
            timer.Stop();
            Console.WriteLine(timer.Elapsed.Ticks);
            timer.Reset();

            //за скільки часу був створений clone (при цьому не був визваний конструктор - v1)
            timer.Start();
            MyClass clone = original.Clone() as MyClass;
            timer.Stop();
            Console.WriteLine(timer.Elapsed.Ticks);
            timer.Reset();

            Console.ReadKey();
        }
    }
}
