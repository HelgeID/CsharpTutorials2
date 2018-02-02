//коварянтність (UpCast параметра типа), out
using System;

namespace Generics
{
    public abstract class Shape { }
    public class Circle: Shape { }

    //"out" і "властивість для читання" - оприділяє використання коварянтності "обобщеній"
    //set використовувати неможемо
    public interface IContainer<out T>//тільки інтерфейси та делегати підтримують техніку коварянтності "обобщеній"
    {
        T Figure { get; }
    }

    public class Container<T>: IContainer<T>
    {
        private T figure;
        public Container(T figure)
        {
            this.figure = figure;
        }

        //реалізація абстрактної властивості базового інтерфейса (тільки для читання)
        public T Figure
        {
            get { return figure; }
        }
    }

    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();
            //UpCast параметра типа
            IContainer<Shape> container = new Container<Circle>(circle);
            Console.WriteLine(container.Figure.ToString());//Generics.Circle

            Console.ReadKey();
        }
    }
}



//контрварянтність (DownCast параметра типа), in
using System;

namespace Generics
{
    public abstract class Shape { }
    public class Circle : Shape { }

    //"in" і "властивість для запису" - оприділяє використання контрваріантності "обобщеній"
    //get використовувати неможемо
    public interface IContainer<in T>//тільки інтерфейси та делегати підтримують техніку контрварянтністі "обобщеній"
    {
        T Figure { set; }
    }

    public class Container<T> : IContainer<T>
    {
        private T figure;
        public Container(T figure)
        {
            this.figure = figure;
        }

        //реалізація абстрактної властивості базового інтерфейса (тільки для запису)
        public T Figure
        {
            set { figure = value; }
        }

        //переоприділення метода ToString
        public override string ToString()
        {
            return figure.GetType().ToString();
        }
    }

    class Program
    {
        static void Main()
        {
            //UpCast до Shape (базового)
            Shape shape = new Circle();

            //DownCast до Circle (похідного) - DownCast параметра типа
            IContainer<Circle> container = new Container<Shape>(shape);
            Console.WriteLine(container.ToString());//Generics.Circle

            Console.ReadKey();
        }
    }
}
