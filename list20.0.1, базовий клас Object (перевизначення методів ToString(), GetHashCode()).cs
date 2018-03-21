//базовий клас Object (перевизначення методів ToString(), GetHashCode())
using System;

namespace ConsoleApplication
{
    class MyClass : Object
    {
        //перевизначення методів, бо методи ToString(), GetHashCode() - віртуальні

        public override string ToString()
        {
            return "Hello, World!";
        }

        //!ps: бажано виконувати перевизначення разом в парі з Equals()
        public override int GetHashCode()
        {
            return 1234567890;
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass ins = new MyClass();
            Console.WriteLine(ins.ToString());//Hello, World!
            Console.WriteLine(ins);//Hello, World!
            Console.WriteLine(ins.GetHashCode());//1234567890

            Console.ReadKey();
        }
    }
}
