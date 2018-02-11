//обробка винятків (вивід інформації)
using System;
using System.Collections;

namespace ConsoleApplication
{
    class MyClass
    {
        public void MyMethod()
        {
            Exception exception = new Exception("my exception");
            exception.HelpLink = "http://MyCompany.com";
            //закидаємо додаткові повідомлення (ключ, значення)
            exception.Data.Add("Add Format: ", "text");
            exception.Data.Add("Add Time: ", DateTime.Now);
            
            throw exception;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyClass ins = new MyClass();
                ins.MyMethod();
            }

            catch (Exception e)
            {
                Console.WriteLine("Name:            {0}", e.TargetSite);
                Console.WriteLine("DeclaringType:   {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("MemberType:      {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:         {0}", e.Message);
                Console.WriteLine("Source:          {0}", e.Source);
                Console.WriteLine("Help Link:       {0}", e.HelpLink);
                Console.WriteLine("Stack:           {0}", e.StackTrace);

                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("{0} : {1}", de.Key, de.Value);
            }

            Console.ReadKey();
        }
    }
}
