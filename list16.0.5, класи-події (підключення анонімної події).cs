//класи, події (підключення анонімної події)
    public delegate void EventDelegate();

    public class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    ...
        static private void Handler1()
        {
            Console.WriteLine("event 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("event 2");
        }


        MyClass ins = new MyClass();

        ins.MyEvent += Handler1;
        ins.MyEvent += Handler2;
        ins.MyEvent += delegate { Console.WriteLine("A"); };
        ins.InvokeEvent();//метод, що викликає подію

        Console.WriteLine(new string('-', 10));
        ins.MyEvent -= Handler2;
        ins.MyEvent -= delegate { Console.WriteLine("A"); };//помилки не має, але не відключає!!!
        ins.InvokeEvent();//метод, що викликає подію
