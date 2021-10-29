using System;

namespace Lesson06
{
    class Program
    {
        static void Main()
        {
            int maxValueOfInt = 2147483647;
            short maxValueOfShort = 32767;
            double doubleNumber = 1.2345;

            maxValueOfInt = maxValueOfShort;
            Console.WriteLine(maxValueOfShort);

            //maxValueOfShort = maxValueOfInt;

            //maxValueOfInt = (int)doubleNumber;
            //Console.WriteLine(maxValueOfInt);

            string text = maxValueOfInt.ToString();
            //Console.WriteLine(text);

            string textFromUser = Console.ReadLine();
            int numberParsed = int.Parse(textFromUser);
            int numberConverted = Convert.ToInt32(textFromUser);
            //Console.WriteLine(numberParsed);
            //Console.WriteLine(numberConverted);

            Console.ReadKey();
        }
    }
}
