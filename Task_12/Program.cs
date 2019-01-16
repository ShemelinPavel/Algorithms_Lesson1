/*

Shemelin Pavel

12

Написать функцию нахождения максимального из трех чисел.

*/

using System;

namespace Task_12
{

    class Program
    {
        /// <summary>
        /// поиск максимального из трех чисел
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <param name="c">третье число</param>
        /// <returns>максимальное число</returns>
        public static int Max( int a, int b, int c )
        {
            int res = ( a > b ) ? a : b;
            res = ( res > c ) ? res : c;

            return res;
        }

        static void Main( string[] args )
        {

            Console.WriteLine( "Введите первое число" );
            int.TryParse( Console.ReadLine(), out int num1 );

            Console.WriteLine( "Введите второе число" );
            int.TryParse( Console.ReadLine(), out int num2 );

            Console.WriteLine( "Введите третье число" );
            int.TryParse( Console.ReadLine(), out int num3 );

            int res = Max( num1, num2, num3 );

            Console.WriteLine( $"\nНаибольшее число: {res}" );
            Console.ReadKey();
        }
    }
}
