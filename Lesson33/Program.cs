using System;
using System.Diagnostics;

namespace Lesson33
{
    class Program
    {
        static void Main()
        {
            const int NUMBER = 3;
            Stopwatch timer = new Stopwatch();

            timer.Start();
            Console.WriteLine($"Calculated factorial for value {NUMBER}: {CalculateFactorial(NUMBER)}.");
            timer.Stop();
            Console.WriteLine($"Elapsed time in ticks: {timer.ElapsedTicks}.\n");

            timer.Restart();
            Console.WriteLine($"Calculated factorial recursively for value {NUMBER}: {CalculateRecursivelyFactorial(NUMBER)}.");
            timer.Stop();
            Console.Write($"Elapsed time in ticks: {timer.ElapsedTicks}.");

            Console.ReadKey();
        }

        private static long CalculateFactorial(int x)
        {
            long score = 1;

            while (x > 1)
            {
                score *= x;
                x--;
            }

            return score;
        }

        private static long CalculateRecursivelyFactorial(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            else
            {
                return CalculateRecursivelyFactorial(x - 1) * x;
            }
        }
    }
}
