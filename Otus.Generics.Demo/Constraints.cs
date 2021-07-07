using System;

namespace Otus.Generics.Demo
{
            class CanConstraint
        {
            public override string ToString() => "Hey!";
        }

        class CannotConstraint
        {
            private int _a;

            public CannotConstraint(int a)
            {
                _a = a;
            }

            public override string ToString() => $"i'm {_a}!";


        }

    public class ConstraintsShower : IBaseDemoShower
    {
        public void Show()
        {
         
            // Можно
            var asInt = new StructConstraint<int>();

            // Ошибка компиляции
            var asString = new StructConstraint<string>();

        }
    }



    class Foo { }

      
    public class NewConstraint<T> where T : new()
    {
        public NewConstraint()
        {
            var v = new T();
            Console.WriteLine($"Hello {v}");
        }

        public void Do<K>() where K : new()
        {
            var v = new K();
            Console.WriteLine($"DO {v}");
        }
    }


    // Т - только value type (int, bool, DateTime, структура)
    public class StructConstraint<T> where T : struct
    {
        public bool AreEqual(T a, T b)
        {
            return a.Equals(b);
        }
    }



    interface IVehicle
    {
        void Start();
        void Go();
    }
    class Auto : IVehicle
    {
        public void Go()
        => Console.WriteLine("Vrum!");

        public void Start()
        => Console.WriteLine("Vruuuuuuuum!");
    }


    class Rider<TV> where TV : IVehicle
    {
        public void RideAVehicle(TV vehicle)
        {
            vehicle.Start();
            vehicle.Go();
        }
    }
}