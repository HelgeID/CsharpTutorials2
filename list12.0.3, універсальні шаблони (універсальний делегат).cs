//універсальні шаблони (універсальний делегат)
using System;

namespace Generics
{
    //T, R - параметри, R - тип вертаючого значення
    delegate R MyDelegate<T, R>(T t);

    class Program
    {
        public static int Add(int i)
        {
            return i*10;
        }

        public static string Concatenation(string str)
        {
            return "Hello " + str + "!";
        }

        static void Main()
        {
            MyDelegate<int, int> myDelegate1 = new MyDelegate<int, int>(Add);
            int i = myDelegate1.Invoke(10);
            Console.WriteLine(i);//100

            MyDelegate<string, string> myDelegate2 = new MyDelegate<string, string>(Concatenation);
            string str = myDelegate2("World");
            Console.WriteLine(str);//Hello World!

            Console.ReadKey();
        }
    }
}
