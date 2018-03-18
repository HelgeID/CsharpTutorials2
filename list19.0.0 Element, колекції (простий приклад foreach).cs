//Element.cs
using System;

namespace ConsoleApplication
{
    public class Element
    {
        private string name;
        private int field1;
        private int field2;

        public Element(string s, int a, int b)
        {
            name = s;
            field1 = a;
            field2 = b;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Field1
        {
            get { return field1; }
            set { field1 = value; }
        }

        public int Field2
        {
            get { return field2; }
            set { field2 = value; }
        }
    }
}
