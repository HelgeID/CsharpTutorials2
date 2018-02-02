//універсальні шаблони (Generic з аргументами різного типу)
    class MyGenerics<TYPE1, TYPE2>
    {
        private TYPE1 variable1;
        private TYPE2 variable2;

        public MyGenerics(TYPE1 arg1, TYPE2 arg2)
        {
            this.variable1 = arg1;
            this.variable2 = arg2;
        }

        public TYPE1 Variable1
        {
            get { return this.variable1; }
            set { this.variable1 = value; }
        }

        public TYPE2 Variable2
        {
            get { return this.variable2; }
            set { this.variable2 = value; }
        }
    }

...
MyGenerics<int, int> ins1 = new MyGenerics<int, int>(10, 20);
Console.WriteLine(ins1.Variable1 + ins1.Variable2);//30
MyGenerics<string, int> ins2 = new MyGenerics<string, int>("Number ", 100);
Console.WriteLine(ins2.Variable1 + ins2.Variable2);//Number 100
MyGenerics<string, string> ins3 = new MyGenerics<string, string>("Hello, ", "World!");
Console.WriteLine(ins3.Variable1 + ins3.Variable2);//Hello, World!
