//перегрузка операторів (== та !=)
using System;

namespace ConsoleApplication
{
    public struct Point
    {
        private int x, y;
        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }

        public override string ToString()
        {
            return string.Format("[{0}][{1}]", this.x, this.y);
        }

        public override bool Equals(object o)
        {
            if (o is Point) {
                if (((Point)o).x == this.x && ((Point)o).y == this.y)
                    return true;
            }
            return false;
        }

        //перевизначення GetHashCode() - обов'язково, при перевизначенню Equals()
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }

    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);
            Console.WriteLine(a == b);//False
            Console.WriteLine(a != b);//True

            Point c = new Point(1, 1);
            Console.WriteLine(a == c);//True
            Console.WriteLine(a != c);//False

            Console.ReadKey();
        }
    }
}
