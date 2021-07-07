using System;

namespace Otus.Generics.Demo
{
    public class Intro<T>
    {
        private T val;

        public Intro(T v)
        => val = v;
        
        public void PrintMe()
        => Console.WriteLine($"I'm '{val}' and my type is '{typeof(T)}'");

        public void PrintMeType<K>(K v)
        => Console.WriteLine($"2. I'm '{v}' and my type is '{v.GetType()}'");
    }
}