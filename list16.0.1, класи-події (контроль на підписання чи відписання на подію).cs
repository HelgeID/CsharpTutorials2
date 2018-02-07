//класи, події (контроль на підписання чи відписання на подію)
    public delegate void EventDelegate();

    public class MyClass
    {
        EventDelegate myEvent = null;

        public event EventDelegate MyEvent
        {
            //контролює підписання і відписання обробника подій
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
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

    ins.MyEvent += Handler1;
    ins.MyEvent += Handler2;
    ins.InvokeEvent();//метод, що викликає подію

    Console.WriteLine(new string('-', 10));
    ins.MyEvent -= Handler2;
    ins.InvokeEvent();//метод, що викликає подію
