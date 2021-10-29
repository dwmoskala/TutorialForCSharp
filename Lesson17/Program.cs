using System;

namespace Lesson17
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.Age = 20;

            Console.WriteLine($"I am {person.Age} years old.");

            Console.ReadKey();
        }
    }
}
