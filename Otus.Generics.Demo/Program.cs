using System;

namespace Otus.Generics.Demo
{

    enum E1
    {
        A = 1
    }


    enum E2
    {
        A = 1,
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Введение в дженерики
            (new IntroShower()).Show();

            (new InheritanceShower()).Show();

            (new MultipleGenericShower()).Show();

            (new DefaultShower()).Show();

            (new ClassConstraintsShower()).Show();

            (new ConstraintsShower()).Show();

            (new CoContrVarShower()).Show();

        }

    }
}
