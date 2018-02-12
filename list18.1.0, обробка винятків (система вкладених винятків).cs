//обробка винятків (система вкладених винятків)
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            try
            {
                try
                {
                    try
                    {
                        throw new Exception("Exception");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Catch 1: " + e.Message);//Exception
                        throw;
                    }
                    finally
                    {
                        Console.WriteLine("Finally 1");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Catch 2: " + e.Message);//Exception
                    throw;
                }
                finally
                {
                    Console.WriteLine("Finally 2");
                    throw new Exception("New Exception");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch 3: " + e.Message);//New Exception
            }
            finally
            {
                Console.WriteLine("Finally 3");
            }

            Console.ReadKey();
        }
    }
}
