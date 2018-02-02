//делегати, лямбда-методы, лямбда оператори, лямбда-вирази

//приклад1
using System;

namespace Delegates
{
    //делегат з параметром і вертає значення
    public delegate int MyDelegate(int a);

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;
            myDelegate = delegate (int x) { return x * 10; }; //Лямбда-метод
            myDelegate = (x) => { return x * 10; }; //Лямбда-оператор
            myDelegate = x => x * 10; //Лямбда-вираз
            int res = myDelegate(2);
            Console.WriteLine(res);//20
            Console.ReadKey();
        }
    }
}



//приклад2
//лямбда-вирази і лямбда оператори
using System;

namespace Delegates
{
    //делегат без параметра
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;
            myDelegate = delegate { Console.WriteLine("Hello 1!"); }; //Лямбда-метод
            myDelegate += () => { Console.WriteLine("Hello 2!"); }; //Лямбда-оператор
            myDelegate += () => Console.WriteLine("Hello 3!"); //Лямбда-вираз
            myDelegate();//Hello 1! Hello 2! Hello 3!
            Console.ReadKey();
        }
    }
}
