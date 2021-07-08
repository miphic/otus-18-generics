using System;
using System.Linq;

namespace Otus.Generics.Demo
{
    /// <summary>
    /// Базовый класс с коллекцией
    /// </summary>
    /// <typeparam name="T">Тип элемента</typeparam>
    public class MyCollection<T>
    {
        public T[] Values { get; set; }
    }

    public class ColOfNumbers
    : MyCollection<double>
    {
        public double GeomAvg()
        {
            var res = 1.0;
            var numOfValues = Values.Length;
            foreach (var v in Values)
            {
                res *= Math.Pow(v, 1.0 / numOfValues);
            }
            return res;
        }
    }

    public class InheritanceShower : IBaseDemoShower
    {
        public void Show()
        {
            var con=new ColOfNumbers();
            con.Values=new double[]{1,2,3,4,5};
            Console.WriteLine($"Avg={con.GeomAvg()}");
        }
    }
}