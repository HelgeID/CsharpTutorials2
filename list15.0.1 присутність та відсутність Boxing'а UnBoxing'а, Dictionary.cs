//присутність та відсутність Boxing'а UnBoxing'а, Dictionary
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            //Boxing
            arrayList.Add(100);
            arrayList.Add((object)200);
            //UnBoxing
            int arrayList_element = (int)arrayList[0];//звертаємось по індексатором
            Console.WriteLine(arrayList_element);
            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine((int)arrayList[i]);

            List<int> list = new List<int>();
            //Boxing'а немає
            list.Add(11);
            list.Add(22);
            //UnBoxing'а немає
            int list_element = list[0];
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(0, "zero");
            dic.Add(1, "one");
            dic.Add(2, "two");
            dic.Add(3, "three");

            Console.WriteLine(dic.ContainsValue("zero"));

            for (int i = 0; i < dic.Count; i++)
                Console.WriteLine(dic[i]);

            Console.ReadKey();
        }
    }
}
