using System;

namespace Lesson07
{
    class Answer1
    {
        public static void DrawRectangle()
        {
            Console.Write("Enter a height of rectangle (integer): ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter a width of rectangle (integer): ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
