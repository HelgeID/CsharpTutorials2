//делегати (створення, виклик метода з конкретного класу)

//приклад1 (статичний клас, метод не приймає параметрів)
    static class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Call Method");
        }
    }

    //створюємо клас-делегата
    public delegate void MyDelegate();

...
//делегат - спеціальний об'єкт, що зберігає всобі адрес на методи
MyDelegate myDelegate = new MyDelegate(MyClass.MyMethod);//створюємо екземпляр-делегата

//виклик метода повідомлень з делегата
//v1
myDelegate.Invoke();//Call Method
//v2 (спрощена форма)
myDelegate();//Call Method



//приклад2 (нестатичний клас, метод не приймає параметрів)
    class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("Call Method");
        }
    }

    public delegate void MyDelegate();

...
MyClass obj = new MyClass();
MyDelegate myDelegate = new MyDelegate(obj.MyMethod);

//виклик метода повідомлень з делегата
//v1
myDelegate.Invoke();//Call Method
//v2 (спрощена форма)
myDelegate();//Call Method



//приклад3 (нестатичний клас, метод (з аргументом) повертає значення)
    class MyClass
    {
        public string MyMethod(string str)
        {
            return str;
        }
    }

    public delegate string MyDelegate(string str);//створюємо клас-делегата

...
MyClass ins = new MyClass();
MyDelegate myDelegate = new MyDelegate(ins.MyMethod);
string str = myDelegate("Hello, World!");
Console.WriteLine(str);//Hello, World!
