//універсальні шаблони (універсальний метод)
    class MyClass
    {
        public void MyMethod<T>(T argument)
        {
            T variable = argument;
            Console.WriteLine(variable);
        }
    }

...
MyClass ins = new MyClass();
//спосіб 1
ins.MyMethod<string>("Hello 1");//Hello 1
//спосіб 2 (явно не вказуємо параметр типа)
ins.MyMethod("Hello 2");//Hello 2
