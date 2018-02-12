//обробка внутрішніх винятків
using System;

namespace ConsoleApplication
{
    public class ClassWithException
    {
        public void ThrowInner()
        {
            //кидаємо внутрішній виняток
            throw new Exception("the inner exception");
        }

        public void CatchInner()
        {
            try
            {
                //викликаємо метод з внутрішнім винятком
                this.ThrowInner();
            }

            catch (Exception e)
            {
                //кидаємо зовнішній виняток, який має в собі внутрішній виняток - e
                throw new Exception("the external exception", e);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassWithException ins = new ClassWithException();
            //ex1 (некоректний приклад)
            //ins.CatchInner();

            //ex2 (правильна обробка внутрішніх винятків)
            try
            {
                ins.CatchInner();
            }

            catch (Exception exception)
            {
                Console.WriteLine("Exception caught: {0}", exception.Message);
                Console.WriteLine("Inner Exception: {0}", exception.InnerException.Message);
            }

            Console.ReadKey();
        }
    }
}
