//обробка винятків (порядок обробки)
using System;

namespace ConsoleApplication
{
    class MyExceptionA : Exception
    {
        public MyExceptionA(string message)
            :base(message)
        {
        }
    }

    class MyExceptionB : MyExceptionA
    {
        public MyExceptionB(string message)
            : base(message)
        {
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                //throw new Exception("Exception");
                throw new MyExceptionA("MyExceptionA");
                //throw new MyExceptionB("MyExceptionB");
            }

            //catch'і є у зворотньому порядку від наслідування:
            //MyExceptionB->MyExceptionA->Exception
            catch (MyExceptionB e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MyExceptionA e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
