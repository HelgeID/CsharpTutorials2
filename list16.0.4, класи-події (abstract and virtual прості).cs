//класи, події (abstract and virtual прості)
    public delegate void EventDelegate();

    interface IInterface
    {
        event EventDelegate MyEvent;
        void InvokeEvent();
    }

    public class BaseClass : IInterface
    {
        //віртуальними можуть бути і незахищені події, без методів add та remove
        public virtual event EventDelegate MyEvent = null;

        public virtual void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent = null;

        public override void InvokeEvent()
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

            DerivedClass ins = new DerivedClass();
            ins.MyEvent += new EventDelegate(Handler1);
            ins.MyEvent += new EventDelegate(Handler2);
            ins.InvokeEvent();//метод, що викликає подію

            ins.MyEvent -= new EventDelegate(Handler2);
            ins.InvokeEvent();//метод, що викликає подію
