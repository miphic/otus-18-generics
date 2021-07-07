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
var lString = new MyList<string>();
var lFoo = new MyList<Foo>();
var lInt = new MyList<int>();
var lBool = new MyList<bool>();




        }


        /// <summary>
        /// Демо дженериков
        /// </summary>
        static void ShowDemo()
        {
            // При создании объекта - указываем тип в '<>'
            var intIntro = new Intro<int>(2);
            intIntro.PrintMe();

            var stringIntro = new Intro<string>("hello");
            stringIntro.PrintMe();

            Console.WriteLine();

            stringIntro.PrintMeType(2.0);

            // Можем явно указывать тип
            stringIntro.PrintMeType<bool>(false);

            // Если тип выводится - может тип <bool> не указывать
            stringIntro.PrintMeType(false);


            Console.WriteLine();


            // Перечисления тоже разделяются по типам
            stringIntro.PrintMeType(E1.A);
            stringIntro.PrintMeType(E2.A);
        }


        #region Множественный дженерик

        public void ShowMultiple()
        {
            var kv1 = new MyKeyValue<int, string>(1, "Hello");
            var kv2 = new MyKeyValue<float, bool>(1f, false);

        }

        #endregion
    }
}
