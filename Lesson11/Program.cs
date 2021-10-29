using System;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello {args[0]} and {args[1]}!");

            //Add(1, 2);
            //Add(4, 5, 6);
            //Add(2, 3, 2, d: 5);

            Console.ReadKey();
        }

        static void Add(int a, int b)
        {
            int score = a + b;
            Console.WriteLine($"{a} + {b} = {score}");
        }

        static void Add(int a, int b, int c)
        {
            int score = a + b + c;
            Console.WriteLine($"{a} + {b} + {c} = {score}");
        }

        static void Add(int a, int b, int c = 0, int d = 0)
        {
            int score = a + b + c + d;
            Console.WriteLine($"{a} + {b} + {c} + {d} = {score}");
        }
    }
}
