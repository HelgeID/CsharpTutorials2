//обробка винятків (вложені винятки)
using System;
using System.IO;

namespace ConsoleApplication
{
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

            catch (UserException userException)
            {
                userException.Method();

                try
                {
                    FileStream fs = File.Open(@"C:\file.log", FileMode.Open);
                }

                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.GetType());
                }
            }

            Console.ReadKey();
        }
    }
}
