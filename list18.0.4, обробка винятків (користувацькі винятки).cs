//обробка винятків (користувацькі винятки)
using System;

namespace ConsoleApplication
{
    //для створення користувацьких винятків, треба наслідувати від System.Exception
    class UserException : Exception
    {
        public void Method()
        {
            Console.WriteLine("my exception");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserException();
            }

            catch (UserException e)
            {
                e.Method();
            }

            Console.ReadKey();
        }
    }
}
