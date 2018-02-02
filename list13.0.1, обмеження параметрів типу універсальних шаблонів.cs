//обмеження параметрів типу універсальних шаблонів

//приклад1
    interface IInterface { /* ... */ }
    interface IInterface<U> { /* ... */ }

    class Derived: IInterface, IInterface<object> { /* ... */ }
    class MyClass1<T> where T : IInterface, IInterface<object> { /* ... */ }
    class MyClass2<T> where T : IInterface { /* ... */ }
    class MyClass3<T> where T : IInterface<object> { /* ... */ }

...
MyClass1<Derived> my1_1 = new MyClass1<Derived>();//Derived має наслідування від двох інтерфейсів
//MyClass1<IInterface> my1_2 = new MyClass1<IInterface>();//error
//MyClass1<IInterface<object>> my1_3 = new MyClass1<IInterface<object>>();//error

MyClass2<IInterface> my2_1 = new MyClass2<IInterface>();
MyClass2<Derived> my2_2 = new MyClass2<Derived>();

MyClass3<IInterface<object>> my3_1 = new MyClass3<IInterface<object>>();
MyClass3<Derived> my3_2 = new MyClass3<Derived>();


//приклад2
    interface IInterface { /* ... */ }
    interface IInterface<U> : IInterface { /* ... */ }

    class Derived: IInterface, IInterface<object> { /* ... */ }
    class Derived2: IInterface<object> { /* ... */ }

    class MyClass1<T> where T : IInterface, IInterface<object> { /* ... */ }
    class MyClass2<T> where T : IInterface<object> { /* ... */ }

...
MyClass1<Derived> my1_1 = new MyClass1<Derived>();
//MyClass1<IInterface> my1_2 = new MyClass1<IInterface>();//error
MyClass1<IInterface<object>> my1_3 = new MyClass1<IInterface<object>>();

MyClass2<Derived> my2_1 = new MyClass2<Derived>();
MyClass2<Derived2> my2_2 = new MyClass2<Derived2>();
MyClass2<IInterface<object>> my2_3 = new MyClass2<IInterface<object>>();
