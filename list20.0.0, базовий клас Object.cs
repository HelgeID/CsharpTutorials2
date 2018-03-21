//базовий клас Object
using System;

namespace ConsoleApplication
{
    //повне ім'я
    class MyClassA: Object
    {
    }

    //аліас (псевдонім)
    class MyClassB: object
    {
    }

    //!!! ps: наслідування тут відбувається неявно, тому
    //": Object" і ": object" можна закоментувати!!!
    class Program
    {
        static void Main()
        {
            Object insA = new MyClassA();
            object insB = new MyClassB();
            Console.ReadKey();
        }
    }
}
