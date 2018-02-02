//делегати, рекурсія в лямбда-операторах
using System;

namespace Delegates
{
    delegate void MyDelegate(int index);

    class Program
    {
        static void Main()
        {
            MyDelegate my = null;

            my = (int i) =>
            {
                i--;
                Console.WriteLine("Begin {0}", i);

                if (i > 0)
                {
                    my(i);
                }

                Console.WriteLine("End {0}", i);
            };

            my(5);

            Console.ReadKey();
        }
    }
}
