﻿using System.Numerics;

namespace Task5
{
    public class Task5
    {
/*
 * Задание 5.1. Запустите функцию `main`, нажав зелёный треугольник слева от её имени. Это действие создаст
 * конфигурацию, которую позже можно отредактировать. В этом задании для ввода данных используются
 * либо параметры командной строки, либо консольный ввод. При запуске через Rider параметры командной строки
 * задаются в окне "Run/Edit configurations..." ("Program arguments:").
 */
        public static void Main(string[] args)
        {
            DemoInput(args);
            ComputeFib(args);
        }

/*
 * Задание 5.2. Разберите код функции `demoInput`.
 */
        internal static void DemoInput(string[] args)
        {
            string name;
            if (args.Length > 0)
            {
                name = string.Join(' ', args);
            }
            else
            {
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine()!;
            }

            Console.WriteLine($"Привет, {name}!");
        }

/*
 * Задание 5.3. Напишите программу, которая принимает на вход целое неотрицательное число
 * (либо параметром командной строки, либо с клавиатуры) и печатает число Фибоначчи:
 * https://ru.wikipedia.org/wiki/%D0%A7%D0%B8%D1%81%D0%BB%D0%B0_%D0%A4%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8
 * с соответствующим номером. Мы считаем, что нулевым числом Фибоначчи является число 0, а первым — число 1.
 *
 * Для представления чисел Фибоначчи следует использовать длинные целые:
 * - https://docs.microsoft.com/ru-ru/dotnet/api/system.numerics.biginteger?view=net-6.0
 */

        /*internal static BigInteger Fib(int n)
        {
            BigInteger bgIn = new BigInteger(n);
            return bgIn;
        }*/

        internal static void ComputeFib(string[] args)
        {
            
            long N;
            if (args.Length > 0)
            {
                N = Int32.Parse(string.Join(' ', args));
            }
            else
            {
                N = Int32.Parse(Console.ReadLine());
            }

            BigInteger a0 = new BigInteger(0);
            BigInteger a1 = new BigInteger(1);
            BigInteger a = new BigInteger();
            for (int i = 0; i < N; i++)
            {
                a = a0;
                a0 = a1;
                a1 += a;
            }
            Console.WriteLine(a0);
        }
    }
}