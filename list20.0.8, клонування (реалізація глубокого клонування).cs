//клонування (реалізація глубокого клонування)
using System;

namespace ConsoleApplication
{
    public class Point: ICloneable
    {
        public int x, y;
        public Point()
        {
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //реалізація метода від і-са ICloneable
        public object Clone()
        {
            return new Point(this.x, this.y) as object;
        }

        public override string ToString()
        {
            return "X: " + x + " Y: " + y;
        }
    }

    class Program
    {
        static void Main()
        {
            Point original = new Point(10, 10);
            Point clone = original.Clone() as Point;
            
            Console.WriteLine(original);//X: 10 Y: 10
            Console.WriteLine(clone);//X: 10 Y: 10

            clone.x = 0;//original.x - не поміняється
            Console.WriteLine(original);//X: 10 Y: 10
            Console.WriteLine(clone);//X: 0 Y: 10

            Console.ReadKey();
        }
    }
}
