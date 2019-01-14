/*

Shemelin Pavel

10

Дано целое число N(> 0).
С помощью операций деления нацело и взятия остатка от деления определить, имеются ли в записи числа N нечетные цифры.
Если имеются, то вывести True, если нет — вывести False.

*/

using System;

namespace Task_10
{
    class Program
    {
        /// <summary>
        /// проверка числа на сожержание в нем нечетных цифр
        /// </summary>
        /// <param name="num">число для проверки</param>
        /// <returns>результат - есть нечетные цифры (true/false)</returns>
        public static bool IsNotEvenNumber( uint num )
        {
            //очередная цифра из числа - остаток деления на 10
            uint divisionResidue_10 = 0;

            while (num > 0)
            {
                divisionResidue_10 = num % 10;
                num = num / 10;
                if (divisionResidue_10 % 2 != 0) return true;
            }
            return false;
        }

        static void Main( string[] args )
        {
            uint Num1 = 75678;
            uint Num2 = 426608;
            bool res;

            Console.WriteLine( $"Проверка числа {Num1}" );
            res = IsNotEvenNumber( Num1 );
            Console.WriteLine( res );

            Console.WriteLine( $"Проверка числа {Num2}" );
            res = IsNotEvenNumber( Num2 );
            Console.WriteLine( res );

            Console.ReadKey();
        }
    }
}
