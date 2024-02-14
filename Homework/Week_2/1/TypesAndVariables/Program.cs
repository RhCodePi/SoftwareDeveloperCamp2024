using System;
using System.Runtime.CompilerServices;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            char character = 'A';
            bool isTrue = false;
            short sNumber = 12;
            int number = 10;
            double dNumber = 10.1;
            decimal decimalNumber = 42.1m;
            long longNumber = 9223372036854775807; // max long number

            var varNumber = 10;

            // enum was value type
            Games game = Games.BaldursGate;
            Games game2 = Games.EldenRing;

            game = game2;

            game2 = Games.RedDeadRedemption;

            Print(character);
            Print(isTrue);
            Print(sNumber);
            Print(number);
            Print(dNumber);
            Print(decimalNumber);
            Print(longNumber);
            Print(game);
            Print(game2);
            Print(varNumber);

        }

        static void Print<T>(T t)
        {
            Console.WriteLine(t + "   Type of => " + typeof(T).Name);
        }
    }

    enum Games
    {
        BaldursGate,
        EldenRing,
        RedDeadRedemption,
    }
}
