using System;

namespace Lesson16
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(PersonStatic.name);
            PersonStatic.name = "Chris";
            Console.WriteLine(PersonStatic.name);

            Person person = new Person();
            //Console.WriteLine(person.surname);
            //person.surname = "Wood";
            //Console.WriteLine(person.surname);
            Person person2 = new Person();
            //Console.WriteLine(person2.surname);
            //Console.WriteLine(Person.age);

            Console.ReadKey();
        }
    }
}
