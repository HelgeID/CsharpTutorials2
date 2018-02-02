//універсальні шаблони (приведення типа)
using System;

namespace Generics
{
    public abstract class Shape { }
    public class Circle: Shape { }

    public interface IContainer<T>
    {
        T Figure { get; set; }
    }

    public class Container<T>: IContainer<T>
    {
        public T Figure { get; set; }

        public Container(T figure)
        {
            this.Figure = figure;
        }
    }

    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();

            //похідний тип
            IContainer<Circle> container1 = new Container<Circle>(circle);
            Console.WriteLine(container1.Figure.ToString());//Generics.Circle
            //базовий тип
            IContainer<Shape> container2 = new Container<Shape>(circle);//неявне приведення типа, за рахунок circle
            Console.WriteLine(container2.Figure.ToString());//Generics.Circle

            Console.ReadKey();
        }
    }
}
