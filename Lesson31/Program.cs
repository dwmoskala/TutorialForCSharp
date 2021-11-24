using System;

namespace Lesson31
{
    class Program
    {
        static void Main()
        {
            Animal animal = new Animal();
            Dog dog = new Dog();

            animal = dog;
            //dog = animal;
            //animal = (Animal)dog;
            //animal = new Dog();

            //if (dog is Animal)
            //{
            //    Dog dog2 = (Dog)animal;

            //    Console.WriteLine("Casting has successful.");
            //}
            //else
            //{
            //    Console.WriteLine("Casting has failed.");
            //}

            //Dog dog2 = animal as Dog;

            //if (dog2 != null)
            //{
            //    Console.WriteLine("Casting has successful.");
            //}
            //else
            //{
            //    Console.WriteLine("Casting has failed.");
            //}

            Console.ReadKey();
        }
    }
}
