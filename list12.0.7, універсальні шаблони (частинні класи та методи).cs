//універсальні шаблони (частинні класи та методи)

    //частинні класи не можуть мати out-параметри
    public partial class MyClass<T>
    {
        partial void PartialMethod<T>(T a, ref T b);
    }

    public partial class MyClass<T>
    {
        partial void PartialMethod<T>(T a, ref T b)
        {
            b = default(T);
            Console.WriteLine("{0}, {1}", a, b);
        }

        public void Proxy(T a, ref T b)
        {
            PartialMethod(a, ref b);
        }
    }

...
MyClass<int> ins = new MyClass<int>();
int operand1 = 1, operand2 = 2;
ins.Proxy(operand1, ref operand2);
Console.WriteLine(operand2);
/*
1, 0
0
*/
