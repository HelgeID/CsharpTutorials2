//перегрузка операторів (Operator+/- через Add() та Subtract())
using System;

namespace ConsoleApplication
{
    public struct Point
    {
        private int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator +(Point p1, Point p2) {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public static Point operator -(Point p1, Point p2) {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", this.x, this.y);
        }

        // Operator+ через Add()
        public static Point Add(Point p1, Point p2) {
            return p1 + p2;
        }
        // Operator- через Subtract()
        public static Point Subtract(Point p1, Point p2) {
            return p1 - p2;
        }
    }

    class Program
    {
        static void Main()
        {
            Point a = new Point(3, 3);
            Point b = new Point(1, 1);

            Console.WriteLine(Point.Add(a, b));//[4, 4]
            Console.WriteLine(Point.Subtract(a, b));//[2, 2]

            Console.ReadKey();
        }
    }
}
