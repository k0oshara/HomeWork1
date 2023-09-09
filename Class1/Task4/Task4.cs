namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for (int i=1;i<=height;i++)
            {
                if (i == 1)
                {
                    for (int j=0;j<width;j++) Console.Write(frameChar);
                }
                else if (i != height)
                {
                    Console.WriteLine();
                    Console.Write(frameChar);
                    for (int g=0;g<width-2;g++) Console.Write(' ');
                    Console.WriteLine(frameChar);
                }
                else
                {
                    for (int q=0;q<width;q++) Console.Write(frameChar);
                }
                
            }
            Console.WriteLine();
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int W = 0;
            int H = 0;
            while (W != width)
            {
                Console.Write(frameChar);
                W++;
            }

            W = 0;
            Console.WriteLine();
            while (H != height-2)
            {
                Console.Write(frameChar);
                while (W != width - 2)
                {
                    Console.Write(' ');
                    W++;
                }
                Console.Write(frameChar);
                H++;
            }
            Console.WriteLine();
            W = 0;
            while (W != width)
            {
                Console.Write(frameChar);
                W++;
            }
            Console.WriteLine();
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            long c;
            
            while (a!=0 && b!=0)
            {
                if (a > b) a = a % b;
                else b = b % a;
            }

            return a+b;
            

            
        }   

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double sm = 0;
            double[] spF = new double[10000];
            double[] spN = new double[10000];
            spF[0] = 1;
            spF[1] = 1;
            spN[0] = 1;
            spN[1] = x;
            for (int i = 0; i <= n; i++)
            {
                sm += spN[i] / spF[i];
                spN[i + 1] = spN[i] * x;
                spF[i + 1] = spF[i] * (i + 1);
            }

            return sm;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            PrintFrame2(5, 3, '+');
            Console.WriteLine(Gcd(14,21));
            Console.WriteLine(ExpTaylor(14,21));
        }
    }
}