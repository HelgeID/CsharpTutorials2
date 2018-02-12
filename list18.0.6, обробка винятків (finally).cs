//обробка винятків (finally)
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int n = 2;

            try
            {
                a = a / (2 - n);
                Console.WriteLine("a = {0}", a);
            }
            
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            //блок finally - виконується завжди
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
