using System;

namespace Lesson18
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GenerateText("My name is #0 and I have #1 years.", "John", 20));

            Console.ReadKey();
        }

        public static string GenerateText(string text, params object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                text = text.Replace("#" + i, args[i].ToString());
            }

            return text;
        }
    }
}
