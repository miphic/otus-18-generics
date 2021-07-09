using System;

namespace Otus.Generics.Demo
{
    interface ICoVar<out T> { }

    class CoVar<T> : ICoVar<T> { }


    class Vehicle { }

    class Automobile : Vehicle { }


    public class CoContrVarShower : IBaseDemoShower
    {


        private void DemonstrateContrVar(IContrVar<Vehicle> vs)
        {
            Console.WriteLine($"{vs}");
        }


        interface IDemo<out T> { }
        
        class ClassDemo<T> : IDemo<T> { }

        public void Show()
        {
            Automobile a = new Automobile();
            Vehicle b = new Vehicle();

            // Так можно
            b = a;



            IDemo<Automobile> demoA = new ClassDemo<Automobile>();
            IDemo<Vehicle> demoB = new ClassDemo<Vehicle>();

            // а так - нельзя
            demoB = demoA;



            ICoVar<Automobile> auto = new CoVar<Automobile>();
            ICoVar<Vehicle> vec = new CoVar<Vehicle>();

            // Теперь можно приводить Automobile к Vehicle
            vec= auto  ;


            IContrVar<Vehicle> v = new ContrVar<Vehicle>();
 IContrVar<Automobile> autocontr = new ContrVar<Automobile>();
            v.Build(new Automobile());

            autocontr=v;

        }
    }







    interface IContrVar<in T>
    {
        void Build(T v);

        
    }

    class ContrVar<T> : IContrVar<T>
    {
        public void Build(T v) { }
    }



}