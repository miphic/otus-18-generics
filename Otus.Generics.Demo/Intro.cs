using System;
using System.Collections.Generic;

namespace Otus.Generics.Demo
{
    public class Intro<THello>
    {
        private THello val;

        public Intro(THello v)
        => val = v;

        public void PrintMe()
        => Console.WriteLine($"I'm '{val}' and my type is '{typeof(THello)}'");

        public void PrintMeType<K>(K v)
        => Console.WriteLine($"2. I'm '{v}' and my type is '{v.GetType()}'");
    }


    public class IntroShower : IBaseDemoShower
    {
        public void Show()
        {
            var listOfInt = new List<int>();
            var listOfStrings = new List<string>();

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
    }
    enum E1
    {
        A = 1
    }


    enum E2
    {
        A = 2,
    }
}