//Boxing, UnBoxing
    //приклад 1
    ...
    short my = 100;
    object boxed = my;//упаковка змінної my (BOXING - перетворення структурного типу в силочний)
    short unboxed = (short)boxed;//розпаковка об'єкта o (UNBOXING - перетворення силочного типу в структурний)

    //приклад 2
    //struct -> ValueType, object, interface
    struct MyStruct //:ValueType
    {
        public void MyMethod()
        {
            Console.WriteLine("MyMethod");
        }
    }

    ...
    MyStruct my = new MyStruct();
    ValueType boxed = my; //BOXING
    MyStruct unboxed = (MyStruct)boxed; //UNBOXING

    //приклад 3
    interface IInterface
    {
        void Method();
    }

    struct MyStruct: IInterface
    {
        public void Method()
        {
            Console.WriteLine("MyMethod");
        }
    }

    ...
    MyStruct my;
    my.Method();
    //упаковка
    IInterface boxed = my;
    boxed.Method();
    //розпаковка
    MyStruct unboxed = (MyStruct)boxed;
