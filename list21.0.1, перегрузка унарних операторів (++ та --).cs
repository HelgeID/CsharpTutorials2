//перегрузка унарних операторів (++ та --)
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

        public static Point operator ++(Point p) {
            return new Point(p.x + 1, p.y + 1);
        }
        public static Point operator --(Point p) {
            return new Point(p.x - 1, p.y - 1);
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
            Point a = new Point(1, 1);
            Console.WriteLine("a = {0}", a);
            //---------------------------------
            //спочатку використовуємо, а потім збільшуємо чи зменшуємо
            Console.WriteLine("a++ = {0}", a++);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("a-- = {0}", a--);
            Console.WriteLine("a = {0}", a);

            //---------------------------------
            //спочатку збільшуємо чи зменшуємо, а потім використовуємо
            Console.WriteLine("++a = {0}", ++a);
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("--a = {0}", --a);
            Console.WriteLine("a = {0}", a);

            Console.ReadKey();
        }
    }
}
