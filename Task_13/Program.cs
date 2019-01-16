/*

Shemelin Pavel

13

Написать функцию, генерирующую случайное число от 1 до 100.
с использованием стандартной функции rand()
без использования стандартной функции rand()

*/


using System;
using System.Threading;

namespace Task_13
{
    class Program
    {

        private static Random r = new Random( 0 );

        /// <summary>
        /// получить случайное число
        /// </summary>
        /// <param name="standardFunc">использовать стандартный генератор случ. чисел</param>
        /// <param name="max">максимальное недостигаемое значение</param>
        /// <returns>случайное число</returns>
        public static int GetRandNum( bool standardFunc, int max )
        {

            if (standardFunc)
            {
                return r.Next( 0, max );
            }
            else
            {
                /*
                реализация xor-shift
                взято здесь: http://www.apofig.com/2014/10/random-xorshift.html
                */

                long time = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                int res = 0;

                time ^= ( time << 21 );
                time ^= ( time >> 35 );
                time ^= ( time << 4 );
                res = (int)time % (max - 1);

                return (res < 0) ? -res : res;
            }

        }

        static void Main( string[] args )
        {

            int res;
            const int Max = 101;

            res = GetRandNum( true, Max );
            Console.WriteLine( $"Случайное число до {Max - 1}  при помощи встроенного генератора случ. чисел: {res}" );

            res = GetRandNum( false, Max );
            Console.WriteLine( $"Случайное число до {Max - 1}  при помощи реализации алгоритма xor-shift: {res}" );

            // чтобы работала зависимость начального значения от времени
            Thread.Sleep( 100 );

            res = GetRandNum( true, Max );
            Console.WriteLine( $"\nСлучайное число до {Max - 1}  при помощи встроенного генератора случ. чисел: {res}" );

            res = GetRandNum( false, Max );
            Console.WriteLine( $"Случайное число до {Max - 1}  при помощи реализации алгоритма xor-shift: {res}" );

            // чтобы работала зависимость начального значения от времени
            Thread.Sleep( 100 );

            res = GetRandNum( true, Max );
            Console.WriteLine( $"\nСлучайное число до {Max - 1}  при помощи встроенного генератора случ. чисел: {res}" );

            res = GetRandNum( false, Max );
            Console.WriteLine( $"Случайное число до {Max - 1}  при помощи реализации алгоритма xor-shift: {res}" );


            Console.ReadKey();
        }
    }
}
