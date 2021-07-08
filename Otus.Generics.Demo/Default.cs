using System;
using System.Collections.Generic;
using System.Numerics;

namespace Otus.Generics.Demo
{
    public static class MyDefault
    {


        public static void DisplayDefault<T>()
        {
          var val=default(T);

            Console.WriteLine($"The value of type {typeof(T)} is: {(val == null ? "null" : val.ToString())}");
      }

    }

    class Foo{}

    public class DefaultShower : IBaseDemoShower
    {
        public void Show()
        {
            MyDefault.DisplayDefault<int>();

            MyDefault.DisplayDefault<bool>();
            MyDefault.DisplayDefault<DateTime>();
            MyDefault.DisplayDefault<Foo>();
            MyDefault.DisplayDefault<string>();
            MyDefault.DisplayDefault<Complex>();
        }
    }
}