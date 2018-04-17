//класи - доступ між просторами імен, при допомозі наслідування

namespace MyNames
{
    namespace NamesA
    {
        class Base
        {
        }
    }

    namespace NamesB
    {
        class Derived: NamesA.Base
        {
        }
    }
}

namespace ConsoleApplication
{
    using MyNames.NamesA;
    using MyNames.NamesB;

    class Program
    {
        static void Main()
        {
            Base ins1 = new Base();
            Derived ins2 = new Derived();

            System.Console.ReadKey();
        }
    }
}
