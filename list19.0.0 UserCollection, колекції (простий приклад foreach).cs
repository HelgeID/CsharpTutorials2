//UserCollection.cs
using System;
using System.Collections;

namespace ConsoleApplication
{
    //UserCollection реалізує два інтерфейси IEnumerable, IEnumerator
    public class UserCollection : IEnumerable, IEnumerator
    {
        //реалізація даних
        public Element[] elementArray = null;
        public UserCollection()
        {
            //створюємо масив
            elementArray = new Element[4];
            //заповняємо масив
            elementArray[0] = new Element("A", 1, 100);
            elementArray[1] = new Element("B", 2, 200);
            elementArray[2] = new Element("C", 3, 300);
            elementArray[3] = new Element("D", 4, 400);
        }

        int position = -1;

        /*
         реалізація інтерфейса IEnumerable
        */
        IEnumerator IEnumerable.GetEnumerator()
        {
            //повертаємо посилання на самого себе
            return this as IEnumerator;
        }

        /*
         реалізація інтерфейса IEnumerator
        */

        //посуваємо вказівник на одну позицію
        public bool MoveNext()
        {
            if (position < elementArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                //Reset();//автоматичний виклик (foreach спрацює повторно)
                return false;
            }
        }

        //встановлюємо вказівник перед початком набору
        public void Reset()
        {
            position = -1;
        }

        //получаємо поточний елемент
        public object Current
        {
            get { return elementArray[position]; }
        }
    }
}
