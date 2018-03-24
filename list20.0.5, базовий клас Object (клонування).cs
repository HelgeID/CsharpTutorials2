//базовий клас Object (клонування)
using System;

namespace ConsoleApplication
{
    class MyClass
    {
        public static string str = "Hello, World!";
        public int number;
    }

    class Program : MyClass
    {
        static void Main()
        {
            Program original = new Program();
            original.number = 100;
            Console.WriteLine(Program.str + " " + original.number);//Hello, World! 100

            //клонування
            Program clone = original.MemberwiseClone() as Program;//створюємо в памяті копію оригіналу(клон)
            Console.WriteLine(Program.str + " " + clone.number);//Hello, World! 100

            //перевірка
            clone.number = 200;
            Program.str = "HI!";

            Console.WriteLine(Program.str + " " + original.number);//HI! 100
            Console.WriteLine(Program.str + " " + clone.number);//HI! 200

            Console.ReadKey();
        }
    }
}
