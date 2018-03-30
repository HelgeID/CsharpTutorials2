//анонімні типи
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            //ins - неявно типізована локальна змінна
            var ins = new { str = "Hello, World!", number = 100 };// { ... } - блок ініціалізатора
            //ins.number = 200; //error, властивості чи індексатори в а.т. тільки для читання
            Console.WriteLine("{0} {1}", ins.str, ins.number);//Hello, World! 100

            //визначення типу
            //Type type = ins.GetType();
            //Console.WriteLine(type.ToString());

            var ins2 = new { str = "Hello!", num = 1, id = new { num = 10 } };//в блоці ініціалізації можна створювати нові анонімні типи
            Console.WriteLine("{0} {1} {2}", ins2.str, ins2.num, ins2.id.num);//Hello! 1 10

            Console.ReadKey();
        }
    }
}
