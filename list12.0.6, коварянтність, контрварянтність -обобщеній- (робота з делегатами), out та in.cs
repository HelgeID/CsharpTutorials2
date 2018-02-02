//коварянтність "обобщеній" (робота з делегатами), out
using System;

namespace Generics
{
    class Animal { }
    class Cat: Animal { }

    class Program
    {
        delegate T MyDelegate<out T>(); //out - для повертаючого значення

        public static Cat CatCreator()
        {
            return new Cat();
        }
        static void Main()
        {
            MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(CatCreator);
            MyDelegate<Animal> delegateAnimal = delegateCat;//від похідного до базового (Cat -> Animal)
            Animal animal = delegateAnimal.Invoke();
            Console.WriteLine(animal.GetType().Name);//Cat
            Console.ReadKey();
        }
    }
}



//контрварянтність "обобщеній" (робота з делегатами), in
using System;

namespace Generics
{
    class Animal { }
    class Cat: Animal { }

    class Program
    {
        delegate void MyDelegate<in T>(T a); //in - для аргумента

        public static void CatUser(Animal animal)
        {
            Console.WriteLine(animal.GetType().Name);
        }
        static void Main()
        {
            MyDelegate<Animal> delegateAnimal = new MyDelegate<Animal>(CatUser);
            MyDelegate<Cat> delegateCat = delegateAnimal;//від базового до похідного (DownCast)

            //передача посилання на екземпляр класа Animal
            delegateAnimal(new Animal());//Animal

            //передача посилання на екземпляр класа Cat
            delegateCat(new Cat());//Cat

            //delegateCat(new Animal());//неможливо тому, що зробити DownCast без попереднього UpCast'а
            Console.ReadKey();
        }
    }
}
