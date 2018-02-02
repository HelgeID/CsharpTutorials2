//обмеження параметрів типу(naked)
    class MyClass<T, R, U> where T : U
    {
    }

    ...
    MyClass<int, Object, int> my1 = new MyClass<int, object, int>();

    MyClass<string, Object, String> my2 = new MyClass<string, object, string>();

    //неспівпадають 1 і 3 аргументи типів (T та U)
    //MyClass<string, Object, int> my3 = new MyClass<string, object, int>();//error
