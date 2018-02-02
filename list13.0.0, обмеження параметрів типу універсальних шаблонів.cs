//обмеження параметрів типу універсальних шаблонів

//приклад1 (class, struct)
    class MyClass1<T> where T: class
    {
        public T variable;
    }

    class MyClass2<T> where T: struct
    {
        public T variable;
    }

...
MyClass1<string> ins1 = new MyClass1<string>();
//MyClass1<int> ins1 = new MyClass1<int>();//error: int - структурний тип
//MyClass2<string> ins2 = new MyClass2<string>();//error: string - "ссылочной" тип
MyClass2<int> ins2 = new MyClass2<int>();



//приклад2 (new())
    //class MyClass<T> where T : class, new() - приклад
    class MyClass<T> where T: new()
    {
        //.. : new() - будемо описувати повноцінне створення екземпляра
        public T ins = new T();
        public void GetValues()
        {
            Console.WriteLine(ins.ToString());//в TestClass ми переоприділяємо ToString
        }
    }

    class TestClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", MyIntProperty, MyStringProperty);
        }
    }

...
MyClass<TestClass> obj = new MyClass<TestClass>();
obj.ins.MyIntProperty = 100;
obj.ins.MyStringProperty = "Hello!";
obj.GetValues();//100 - Hello!



//приклад3 (Base, Derived)
    class Base { }
    class Derived : Base { }

    class MyClass<T> where T : Base
    {
    }

...
MyClass<Base> ins1 = new MyClass<Base>();
MyClass<Derived> ins2 = new MyClass<Derived>();
//MyClass<string> ins3 = new MyClass<string>();//error
