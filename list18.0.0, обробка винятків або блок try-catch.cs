//обробка винятків або блок try-catch
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
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            Console.ReadKey();
        }
    }
}
