using System;
using System.Collections.Generic;

namespace Otus.Generics.Demo
{
    public interface IMy<out T> { }

    public class My<T> : IMy<T> { }


    public class Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("Vehicle");
        }
    }

    public class Automobile : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("I'm CAR");
        }
    }

    class SuperAuto : Automobile { }

    public class CoContrVarShower : IBaseDemoShower
    {


        private void DemonstrateContrVar(IFancyComparator<Vehicle> vs)
        {
            Console.WriteLine($"{vs}");
        }


        interface IDemo<out T>
        {
            void Print();

        }

        class ClassDemo<T> : IDemo<T>
        {
            public void Print()
            {
                Console.WriteLine($"I work with {typeof(T)}");
            }
        }

        public void GetVehicle(Vehicle v)
        {
            v.Go();
        }
        public void Show()
        {
            Automobile a = new Automobile();
            Vehicle b = new Vehicle();

            // Так можно
            b = a;

            GetVehicle(b);

            //     return;

            IDemo<Automobile> demoAuto = new ClassDemo<Automobile>();
            IDemo<Vehicle> demoVehicle = new ClassDemo<Vehicle>();

            // а так - нельзя
            demoVehicle = demoAuto;


            IMy<SuperAuto> auto = new My<SuperAuto>();
            IMy<Vehicle> vec = new My<Vehicle>();

            //// Теперь можно приводить Automobile к Vehicle
            vec = auto;

            IFancyComparator<Automobile> autocontr = new FancyComparator<Vehicle>();

            autocontr.Build(new Automobile());

            var a1 = new Automobile();
            var a2 = new Automobile();
            Compare2Autos(a1, a2, autocontr);

        }

        public void Compare2Autos(
            Automobile a1,
            Automobile a2,
            IFancyComparator<Automobile> comparator)
        {

        }

    }







    public interface IFancyComparator<in T>
    {
        void Build(T v);
    }

    public class FancyComparator<T> : IFancyComparator<T>
           where T : Vehicle
    {
        public void Build(T v)
        {
            Console.WriteLine($"I'm typeof {typeof(T)}");
            v.Go();
        }
    }



}