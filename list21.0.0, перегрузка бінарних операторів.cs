//перегрузка бінарних операторів
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

        //operator використовується разом з static
        public static Point operator +(Point p1, Point p2) {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public static Point operator -(Point p1, Point p2) {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }
        public static Point operator *(Point p1, Point p2) {
            return new Point(p1.x * p2.x, p1.y * p2.y);
        }
        public static Point operator /(Point p1, Point p2) {
            return new Point(p1.x / p2.x, p1.y / p2.y);
        }

        public override string ToString()
        {
            return string.Format("[{0}][{1}]", this.x, this.y);
        }
    }

    class Program
    {
        static void Main()
        {
            Point a = new Point(6, 6);
            Point b = new Point(3, 3);
            Console.WriteLine("operator+  : {0}", a + b);//operator+  : [9][9]
            Console.WriteLine("operator-  : {0}", a - b);//operator-  : [3][3]
            Console.WriteLine("operator*  : {0}", a * b);//operator*  : [18][18]
            Console.WriteLine("operator/  : {0}", a / b);//operator/  : [2][2]

            //Point res = new Point(1, 1);
            //Point p = new Point(2, 2);
            //res += p;
            //Console.WriteLine(res);//[3][3]

            Console.ReadKey();
        }
    }
}
