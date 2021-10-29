using System;

namespace Lesson03
{
    class Program
    {
        static void Main()
        {
            int a = 2;
            int b = 4;
            int choose = 1;

            if (a < b)
            {
                Console.WriteLine(a + " is less than " + b);
            }
            if (a < 5)
            {
                Console.WriteLine(a + " is less than 5");
            }
            else if (a == b)
            {
                Console.WriteLine(a + " is equal to " + b);
            }
            else
            {
                Console.WriteLine(a + " is greater than " + b);
            }

            switch (choose)
            {
                case 1:
                    {
                        Console.Write("Choice number 1.");
                    }
                    break;

                case 2:
                    {
                        Console.Write("Choice number 2.");
                    }
                    break;

                default:
                    {
                        Console.Write("Wrong choice!");
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
