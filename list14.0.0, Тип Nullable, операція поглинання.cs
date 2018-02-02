//Тип Nullable, операція поглинання

//приклад1
int? a = null;//a - містить невідоме значення
int? b = a + 5;//b = null
int? c = a * 5;//c = null
Console.WriteLine(">{0}<", a);//><



//приклад2
int? a = null;
int? b = -5;//b=-5

//не має смисла порівнювати!!!
//(Якщо один з операндів == null, то результат - завжди false)
if (a >= b)
    Console.WriteLine("true");//true
else
    Console.WriteLine("false");//false

//(Якщо двоє операндів == null, то результат - завжди true)
b = null;
if (a == b)
    Console.WriteLine("true");//true
else
    Console.WriteLine("false");//false



//операція поглинання
int? a = null;
int? b;//значення по-замовчуванню рівне null

/*
b = (a != null) ? a : 10; //то саме, що: b = a ?? 10;
*/

b = a ?? 10;
Console.WriteLine(b);//10

a = 3;
b = a ?? 10;
Console.WriteLine(b);//3



//коротка нотація Nullable - "?"
Nullable<int> a = 10;
if (a.HasValue == true)
    Console.WriteLine("a є {0}", a.Value);

int? b = 10;
if (b.HasValue == true)
    Console.WriteLine("b є {0}", b.Value);

//var? c = null;//error - неявно типізована локальна змінна не може бути Nullable
