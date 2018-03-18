//колекції (простий приклад foreach)

//Program.cs
using System;
using System.Collections;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            //v1-a
            UserCollection myCollection = new UserCollection();
            foreach (Element element in myCollection)
            {
                Console.WriteLine("{0} {1} {2}", element.Name, element.Field1, element.Field2);
            }
            Console.Write(new string('-', 10) + "\n");

            //v1-b
            myCollection.Reset();//ручний виклик (без Reset foreach не спрацює)
            foreach (Element element in myCollection)
            {
                Console.WriteLine("{0} {1} {2}", element.Name, element.Field1, element.Field2);
            }
            Console.Write(new string('-', 10) + "\n");

            //v2
            UserCollection myElementCollection = new UserCollection();
            IEnumerable enumerable = myElementCollection as IEnumerable; //foreach приводить колекцію до інтерфейсного типу
            IEnumerator enumerator = enumerable.GetEnumerator(); //foreach приводить колекцію до інтерфейсного типу, викликаючи метод GetEnumerator()
            while (enumerator.MoveNext())
            {
                Element element = enumerator.Current as Element;
                Console.WriteLine("{0} {1} {2}", element.Name, element.Field1, element.Field2);
            }
            enumerator.Reset();
            Console.Write(new string('-', 10) + "\n");

            //приклад з масивом
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
    }
}
