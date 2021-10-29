using System;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b;
            int[] tab = new int [2];
            tab[0] = 2;
            tab[1] = 5;

            Console.WriteLine("Before: " + a);
            ShowCopy(a);
            //ShowOriginal(ref a);
            Console.WriteLine("After: " + a);

            //ShowWithoutAssignment(out b);

            //Console.WriteLine($"Before: {tab[0]}, {tab[1]}.");
            //ShowTable(tab);
            //ShowCopyTable(tab);
            //Console.WriteLine($"After: {tab[0]}, {tab[1]}.");

            Console.ReadKey();
        }

        static void ShowCopy(int a)
        {
            a += 5;
            Console.WriteLine("In method: " + a);
        }

        static void ShowOriginal(ref int number)
        {
            number += 5;
            Console.WriteLine("In method: " + number);
        }

        static void ShowWithoutAssignment(out int b)
        {
            b = 5;

            Console.WriteLine(b);
        }

        static void ShowTable(int[] tab)
        {
            tab[0] = 222;
            tab[1] = 555;

            Console.WriteLine($"In method: {tab[0]}, {tab[1]}.");
        }

        static void ShowCopyTable(int[] tab)
        {
            tab = new int[2];
            tab[0] = -22;
            tab[1] = -55;

            Console.WriteLine($"In method: {tab[0]}, {tab[1]}.");
        }
    }
}
