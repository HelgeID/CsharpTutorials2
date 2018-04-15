//класи - глобальний простір імен, директива using

//using System;
class Program
{
    static void Main()
    {
        //Console.WriteLine(100);//error - без директиви using не працює
        System.Console.WriteLine("Hello, World!");
        System.Console.ReadKey();
    }
}
