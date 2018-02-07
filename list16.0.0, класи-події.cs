//класи, події
    public delegate void EventDelegate();

    public class MyClass
    {
        //поля типу делегага - подія
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    ...
    //методи обробника подій
    static private void Handler1()
    {
        Console.WriteLine("event 1");
    }

    static private void Handler2()
    {
        Console.WriteLine("event 2");
    }

    MyClass ins = new MyClass();
    //підписка на подію (приєднання обробника подій)
    ins.MyEvent += new EventDelegate(Handler1);
    ins.MyEvent += Handler2;
    ins.InvokeEvent();//метод, що викликає подію

    Console.WriteLine(new string('-', 10));

    //відкріплюєм Handler2()
    ins.MyEvent -= new EventDelegate(Handler2);
    ins.InvokeEvent();//метод, що викликає подію
    