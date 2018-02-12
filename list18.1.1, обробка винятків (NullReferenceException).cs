//обробка винятків (NullReferenceException)
using System;

namespace ConsoleApplication
{
    //class MyClass
    //{
    //    public void Method()
    //    {
    //        Console.WriteLine("My Method");
    //    }
    //}

    class Program
    {
        static void Main()
        {
            //v1
            //MyClass my = null;
            //my.Method();//System.NullReferenceException

            //v2
            try
            {
                throw null;
                //или
                //Exception my = null;
                //throw my;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());//System.NullReferenceException
            }

            Console.ReadKey();
        }
    }
}
