using System;

namespace Lesson14
{
    class Program
    {
        static void Main()
        {
            Man man1 = new Man();
            Console.WriteLine(man1.name);

            man1.name = "Mike";
            //Console.WriteLine(man1.name);

            Man man2 = new Man();
            //Console.WriteLine(man2.name);

            //man1.ShowName();
            //man2.ShowName();

            Woman woman1 = new Woman();
            //Console.WriteLine(woman1.name);

            Console.ReadKey();
        }
    }

    class Man
    {
        public string name = "John";

        public void ShowName()
        {
            Console.WriteLine($"My name is {name}.");
        }
    }
}
