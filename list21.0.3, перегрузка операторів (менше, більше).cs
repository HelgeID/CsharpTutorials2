//перегрузка операторів (<,>,<=,>=)
using System;

namespace ConsoleApplication
{
    public struct Point : IComparable
    {
        private int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator <(Point p1, Point p2) {
            return (p1.CompareTo(p2) < 0);
        }
        public static bool operator >(Point p1, Point p2) {
            return (p1.CompareTo(p2) > 0);
        }
        public static bool operator <=(Point p1, Point p2) {
            return (p1.CompareTo(p2) <= 0);
        }
        public static bool operator >=(Point p1, Point p2) {
            return (p1.CompareTo(p2) >= 0);
        }

        //реалізація інтерфейса IComparable
        public int CompareTo(object obj)
        {
            if (obj is Point)
            {
                Point p = (Point)obj;
                if (this.x > p.x && this.y > p.y) {
                    return 1;
                }
                else if (this.x < p.x && this.y < p.y) {
                    return -1;
                }
                else {
                    return 0;
                }
            }
            else {
                throw new ArgumentException();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);
            Point c = new Point(1, 1);

            Console.WriteLine(a < b);//True
            Console.WriteLine(a > b);//False

            Console.WriteLine(a <= c);//True
            Console.WriteLine(b >= c);//True

            Console.ReadKey();
        }
    }
}
