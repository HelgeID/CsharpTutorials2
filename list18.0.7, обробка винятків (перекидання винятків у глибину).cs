//обробка винятків (перекидання винятків у глибину)
using System;

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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("обробка винятка 1:");
                userException.Method();

                try
                {
                    //перекидаємо ще раз виняток
                    throw userException;
                }

                catch (UserException exception)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("обробка винятка 2:");
                    exception.Method();
                }
            }

            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
