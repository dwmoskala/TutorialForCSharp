using System;
using System.Linq;

namespace Lesson10
{
    class Program
    {
        static void Main()
        {
            int[][] jaggedTab = new int[2][];
            jaggedTab[0] = new int[3];
            jaggedTab[1] = new int[2];

            for (int i = 0; i < jaggedTab.Length; i++)
            {
                for (int j = 0; j < jaggedTab[i].Length; j++)
                {
                    jaggedTab[i][j] = i + j;
                    Console.Write(jaggedTab[i][j] + " ");
                }

                Console.WriteLine();
            }

            int[] tab = { 5, 15, 10 };
            //Console.WriteLine(tab.Max());
            //Console.WriteLine(tab.Min());
            //Console.WriteLine(tab.Sum());

            Console.ReadKey();
        }
    }
}
