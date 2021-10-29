using System;

namespace Lesson15
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("I am the constructor.");
        }

        public Person(string constructorName)
        {
            name = constructorName;
        }

        public Person(string constructorName, string constructorSurname)
        {
            name = constructorName;
            surname = constructorSurname;
        }

        public string name = "John";
        public string surname = "Smith";

        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {name} {surname}.");
        }

        ~Person()
        {
            Console.WriteLine("I am the destructor.");
        }
    }
}
