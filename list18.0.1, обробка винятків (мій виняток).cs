//обробка винятків (мій виняток)
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception - базовий клас для всіх винятків
            Exception ex = new Exception("my exception");

            try
            {
                throw ex;
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);//my exception
            }

            Console.ReadKey();
        }
    }
}
