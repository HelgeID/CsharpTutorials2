//UserCollection.cs
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApplication
{
    class UserCollection
    {
        public static IEnumerable Power()
        {
            //yield - генератор програмних кодів колекцій (озн. повертати, видавати)
            yield return "Hello world!";

            //yield return "1";
            //yield return "2";
            //yield return "3";

            //yield break;//нічого не повертає

            //while (true)
            //    yield return "Hello world!";
        }
    }
}
