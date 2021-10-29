using System;

namespace Lesson02
{
    class Program
    {
        static void Main()
        {
            int a = 4;
            int b = 2;
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int dividingCompletely = a / b;
            int theRestOfTheDivision = a % b;

            Console.WriteLine(addition);

            a += 1;
            a -= 2;
            a *= 3;
            a /= 4;
            a++;
            a--;

            bool h = a < 3;
            bool i = a >= 5;
            bool j = a == 2;
            bool k = a != 2;
            bool l = a > 2 && b < 4;
            bool m = a > 2 || b < 4;

            Console.ReadKey();
        }
    }
}
