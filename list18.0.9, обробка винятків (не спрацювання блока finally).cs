//обробка винятків (не спрацювання блока finally)
using System;

namespace ConsoleApplication
{
    class Program
    {
        public static void Method()
        {
            //блок finally - не спрацює, System.StackOverflowException
            //int[] arr = new int[10];
            //Console.WriteLine(arr);
            //Method();

            //блок finally - спрацює, System.OutOfMemoryException
            //int[] arr = new int[100000000];
            //Console.WriteLine(arr);
            //Method();
        }

        static void Main()
        {
            try
            {
                Method();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.ReadKey();
        }
    }
}

/*
//блок finally не спрацює

try
{
    throw new Exception();
}

catch (Exception)
{
    //v1
    throw new Exception();

    //v2
    while (true)
        Console.WriteLine("catch");
}

finally
{
    while (true)
        Console.WriteLine("finally");
}

*/
