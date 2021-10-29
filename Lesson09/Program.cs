using System;

namespace Lesson09
{
    class Program
    {
        static void Main()
        {
            string[] week = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }

            int[] tab = new int[10];
            //tab[10] = 10;

            int[,] tab2D = new int[2, 2];

            //for (int i = 0; i < tab2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tab2D.GetLength(1); j++)
            //    {
            //        tab2D[i, j] = i + j;
            //        Console.Write(tab2D[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
