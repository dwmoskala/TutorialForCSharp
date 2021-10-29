using System;

namespace Lesson04
{
    class Program
    {
        static void Main()
        {
            int a = 1;
            int b = 1;
            int c = 1;

            while (a < 2)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine();

            do
            {
                Console.WriteLine(b);
                b++;
            } while (b < 2);

            Console.WriteLine();

            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine(c);
                c++;
            }

            Console.ReadKey();
        }
    }
}
