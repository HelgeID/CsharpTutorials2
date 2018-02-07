//класи, події (abstract and virtual)
    public delegate void EventDelegate();

    interface IInterface
    {
        event EventDelegate MyEvent;//абстрактна подія
    }

    public class BaseClass : IInterface
    {
        EventDelegate myEvent = null;
        
        public virtual event EventDelegate MyEvent//віртуальна подія
        {
            add { myEvent += value; }
            remove { myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    public class DerivedClass : BaseClass
    {
        public override event EventDelegate MyEvent//переоприділена подія
        {
            add
            {
                base.MyEvent += value;
                Console.WriteLine("Event base class add {0}", value.Method.Name);
            }

            remove
            {
                base.MyEvent -= value;
                Console.WriteLine("Event base class remove {0}", value.Method.Name);
            }
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


        DerivedClass ins = new DerivedClass();
        ins.MyEvent += new EventDelegate(Handler1);
        ins.MyEvent += new EventDelegate(Handler2);
        ins.InvokeEvent();//метод, що викликає подію

        ins.MyEvent -= new EventDelegate(Handler2);
        ins.InvokeEvent();//метод, що викликає подію
    