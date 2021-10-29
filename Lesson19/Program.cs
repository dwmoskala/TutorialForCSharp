using System;
using System.Diagnostics;
using System.Text;

namespace Lesson19
{
    class Program
    {
        static void Main()
        {
            int counter = 10000;
            Stopwatch stopWatch = new Stopwatch();
            
            stopWatch.Start();
            StringConcatenation(counter);
            stopWatch.Stop();
            Console.WriteLine($"Standard method: {stopWatch.ElapsedMilliseconds} ms.");

            stopWatch.Reset();
            stopWatch.Start();
            StringBuilder(counter);
            stopWatch.Stop();
            Console.WriteLine($"StringBuilder method: {stopWatch.ElapsedMilliseconds} ms.");

            Console.ReadKey();
        }

        /// <summary>
        /// Builds a string.
        /// </summary>
        /// <param name="counter">Enter length of loop.</param>
        /// <returns>A built string.</returns>
        public static string StringConcatenation(int counter)
        {
            string text = "";

            for (int i = 0; i < counter; i++)
            {
                text += i;
            }

            return text;
        }

        public static string StringBuilder(int counter)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < counter; i++)
            {
                stringBuilder.Append(i);
            }

            return stringBuilder.ToString();
        }
    }
}
