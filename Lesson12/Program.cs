using System;

namespace Lesson12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Add(2, 3));

            //Console.WriteLine(Check(2, 3));

            //Add2(5, 6);

            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            int score = a + b;

            return score;
        }

        //static string Check(int a, int b)
        //{
        //    if (a > b)
        //    {
        //        string score = $"{a} is greater than {b}.";

        //        return score;
        //    }
        //    else if (a == b)
        //    {
        //        string score = $"{a} is equal to {b}.";

        //        return score;
        //    }
        //    else
        //    {
        //        string score = $"{a} is less than {b}.";

        //        return score;
        //    }

        //}

        //static void Add2(int a, int b)
        //{
        //    Console.WriteLine($"{a} + {b} is {a + b}");
        //}
    }
}
