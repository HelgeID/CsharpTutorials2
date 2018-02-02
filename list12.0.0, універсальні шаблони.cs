//універсальні шаблони
    //параметризований вказівникoм місця заповнення типом T клас MyClass
    class MyClass<T>
    {
        public T myField;
        public void MyMethod()
        {
            Console.WriteLine(myField.GetType());
        }
    }

...
MyClass<int> ins1 = new MyClass<int>();
ins1.MyMethod();//System.Int32
MyClass<long> ins2 = new MyClass<long>();
ins2.MyMethod();//System.Int64
MyClass<string> ins3 = new MyClass<string>();
ins3.myField = "Hello, World!";
ins3.MyMethod();//System.String
