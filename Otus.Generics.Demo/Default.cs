using System;
using System.Collections.Generic;

namespace Otus.Generics.Demo
{
    public class MyDefault<T>
    {
        public bool Se;


        public List<T> CreateEmptyList(int size)
        {
            var res = new List<T>();

            for (var i = 0; i < size; i++)
            {
                res.Add(default(T));
            }

            return res;
        }

    }

    public class DefaultShower : IBaseDemoShower
    {
        public void Show()
        {
               // var d=new MyDefault<string>();
            // d.CreateEmptyArray();
            // d.Value="";
            // d.CreateEmptyArray();
        }
    }
}