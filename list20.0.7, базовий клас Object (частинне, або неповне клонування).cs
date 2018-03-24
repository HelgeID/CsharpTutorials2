//базовий клас Object (частинне, або неповне клонування)

//!!!Правило: наслідування клонується глубоко, а асоціації - поверхнево
using System;

namespace ConsoleApplication
{
    class A { public int a = 1; }
    class B { public int b = 2; }
    class C { public B B = new B(); }

    class X
    {
        public A A = new A();
        public C C = new C();
    }

    class Program : X
    {
        static void Main()
        {
            Program original = new Program();
            Console.WriteLine("original: " + original.A.a + ", " + original.C.B.b);//original: 1, 2

            //клонування (тут склонувався тільки граф наслідування (Program <- X), а екземпляри класів A, B, C - спільні для клона і оригінала)
            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine("clone: " + clone.A.a + ", " + clone.C.B.b);//clone: 1, 2

            clone.A.a = clone.C.B.b = 100;
            Console.WriteLine("original: " + original.A.a + ", " + original.C.B.b);//original: 100, 100
            Console.WriteLine("clone: " + clone.A.a + ", " + clone.C.B.b);//clone: 100, 100

            Console.ReadKey();
        }
    }
}
