//обробка винятків (мій виняток, по слабому посиланню)
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("my exception");
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);//my exception
            }

            Console.ReadKey();
        }
    }
}
