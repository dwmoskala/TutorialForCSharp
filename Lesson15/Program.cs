using System;

namespace Lesson15
{
    class Program
    {
        static void Main()
        {
            Person john = new Person();
            john.IntroduceYourself();

            Person peter = new Person("Peter");
            //peter.IntroduceYourself();

            Person mike = new Person("Mike", "Hawk");
            //mike.IntroduceYourself();

            Console.ReadKey();
        }
    }
}
