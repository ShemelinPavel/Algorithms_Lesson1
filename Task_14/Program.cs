/*

Shemelin Pavel

14

Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата. Например, 25^2 = 625.
Напишите программу, которая вводит натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    class Program
    {
        /// <summary>
        /// печать автомарфных чисел 
        /// </summary>
        /// <param name="num">максимальное значение ряда натуральных чисел</param>
        public static void PrintAutomorphNumbers( uint num )
        {
            for (int i = 1; i <= num; i++)
            {
                //счетчик порядка натурального числа
                uint decCounter = 1;

                int currentNum = i / 10;
                while (currentNum != 0)
                {
                    decCounter++;
                    currentNum = currentNum / 10;
                }

                UInt32 res = (UInt32)Math.Pow( i, 2 );

                if (res % ( Math.Pow( 10, decCounter ) ) == i) Console.WriteLine( i );
            }
        }

        static void Main( string[] args )
        {

            Console.WriteLine( "Введите натуральное число:" );
            bool res = uint.TryParse( Console.ReadLine(), out uint userAnswer );
            if (res && userAnswer > 0) PrintAutomorphNumbers( userAnswer );
            else Console.WriteLine( "Введеное значение не является натуральным числом!" );

            Console.ReadKey();

        }
    }
}
