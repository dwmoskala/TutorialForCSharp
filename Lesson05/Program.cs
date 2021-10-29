using System;

namespace Lesson05
{
    class Program
    {
        static void Main()
        {
            //single line comment

            /*multi
             *line
             *comment
             */

            string text1 = "Hello ";
            string text2 = "World";
            Console.WriteLine(text1 + text2 + "!");
            Console.WriteLine("{0}{1}!", text1, text2);
            Console.WriteLine($"{text1}{text2}!");

            Console.ReadKey();
        }
    }
}
