//базовий клас Object (перевизначення методів GetHashCode() та Equals())
using System;

namespace ConsoleApplication
{
    class Point : object
    {
        protected int x, y;

        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Point p = (Point)obj;
            return (x == p.x) && (y == p.y);
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }
    }

    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(0, 0);

            Console.WriteLine(a.Equals(b)); //True
            Console.WriteLine(a.Equals(c)); //False

            //співпали хеши
            Console.WriteLine(object.Equals(a, b)); //True
            //порівнює значення адрес a та b в пам'яті
            Console.WriteLine(object.ReferenceEquals(a, b)); //False

            Console.ReadKey();
        }
    }
}
