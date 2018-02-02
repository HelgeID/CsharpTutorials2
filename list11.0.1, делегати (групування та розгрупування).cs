//делегати (групування та розгрупування)
using System;

namespace Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        //Методи
        public static void Method1() { Console.WriteLine("Call Method1"); }
        public static void Method2() { Console.WriteLine("Call Method2"); }
        public static void Method3() { Console.WriteLine("Call Method3"); }

        static void Main()
        {
            MyDelegate myDelegateSUM = null;
            MyDelegate myDelegate = null;

            MyDelegate myDelegate1 = new MyDelegate(Method1);
            MyDelegate myDelegate2 = new MyDelegate(Method2);
            MyDelegate myDelegate3 = new MyDelegate(Method3);

            //комбінуємо типи ("+" є знаком групування)
            myDelegateSUM = myDelegate1 + myDelegate2 + myDelegate3;

            //myDelegate1.Invoke();//Call Method1
            //myDelegate2.Invoke();//Call Method2
            //myDelegate3.Invoke();//Call Method3
            //myDelegateSUM.Invoke();//Call Method1 Call Method2 Call Method3

            //комбінуємо типи ("-" є знаком розгрупування)
            myDelegate = myDelegateSUM - myDelegate1;
            //myDelegate.Invoke();//Call Method2 Call Method3
            myDelegate = myDelegateSUM - myDelegate2;
            //myDelegate.Invoke();//Call Method1 Call Method3
            myDelegate = myDelegateSUM - myDelegate3;
            //myDelegate.Invoke();//Call Method1 Call Method2

            Console.ReadKey();
        }
    }
}
