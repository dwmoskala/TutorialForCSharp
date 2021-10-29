using System;

namespace Lesson08
{
    class Program
    {
        static void Main()
        {
            int a = 0;

            while (true)
            {
                if (a > 10)
                {
                    break;
                }

                Console.WriteLine(a);
                a++;
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i);
            //}

            //menu:
            //    Console.WriteLine("1.");
            //    Console.WriteLine("2.");
            //    Console.Write("Choose option: ");
            //    var choose = int.Parse(Console.ReadLine());
            //    if (choose == 1)
            //    {
            //        goto one;
            //    }
            //    else if (choose == 2)
            //    {
            //        goto two;
            //    }
            //    else
            //    {
            //        goto wrong;
            //    }
            //one:
            //    Console.WriteLine("First option chosen.");
            //    Console.ReadKey();
            //    goto menu;
            //two:
            //    Console.WriteLine("Second option chosen.");
            //    Console.ReadKey();
            //    goto menu;
            //wrong:
            //    Console.WriteLine("Wrong option chosen.");
            //    Console.ReadKey();
            //    goto menu;

            Console.ReadKey();
        }
    }
}
