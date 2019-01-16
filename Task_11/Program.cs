/*

Shemelin Pavel

11

С клавиатуры вводятся числа, пока не будет введен 0.
Подсчитать среднее арифметическое всех положительных четных чисел, оканчивающихся на 8.

*/

using System;
using System.Collections.Generic;

namespace Task_11
{
    class Program
    {
        /// <summary>
        /// подсчет среднеарифметического
        /// </summary>
        /// <param name="list">коллекция чисел</param>
        /// <returns>среднее арифметическое</returns>
        public static double CountAverage( List<int> list )
        {
            int counter = 0;
            double sum = 0;

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (( list[i] > 0 ) && (list[i] % 10 == 8 ))
                {
                    Console.WriteLine( $"Положительное число оканчивающееся на 8: {list[i]}" );
                    sum += list[i];
                    counter++;
                }
            }
            return ( counter == 0 ) ? 0 : sum / counter;
        }

        static void Main( string[] args )
        {

            List<int> numList = new List<int>();

            do
            {
                Console.WriteLine( "Введите число. Для выхода введите 0" );
                bool resParse = int.TryParse( Console.ReadLine(), out int userAns );
                if (resParse) numList.Add( userAns );

            } while (numList[numList.Count - 1] != 0);

            double res = CountAverage( numList );

            Console.WriteLine( $"\nСреднее арифметическое всех положительных чисел оканчивающихся на 8: {res}" );
            Console.ReadKey();

        }
    }
}
