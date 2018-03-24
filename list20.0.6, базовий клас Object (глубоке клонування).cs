//базовий клас Object (глубоке клонування)
using System;

namespace ConsoleApplication
{
    class A     { public int a = 1; }
    class B : A { public int b = 2; }
    class C : B { public int c = 3; }
    class X : C { }

    class Program : X
    {
        static void Main()
        {
            Program original = new Program();
            Console.WriteLine("original: {0}, {1}, {2}", original.a, original.b, original.c);//original: 1, 2, 3

            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine("clone: {0}, {1}, {2}", clone.a, clone.b, clone.c);//clone: 1, 2, 3

            //перевірка на глубоке клонування
            clone.a = clone.b = clone.c = 100;

            Console.WriteLine("original: {0}, {1}, {2}", original.a, original.b, original.c);//original: 1, 2, 3
            Console.WriteLine("clone: {0}, {1}, {2}", clone.a, clone.b, clone.c);//clone: 100, 100, 100

            Console.ReadKey();
        }
    }
}
