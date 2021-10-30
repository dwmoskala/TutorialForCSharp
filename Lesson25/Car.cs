using System;

namespace Lesson25
{
    abstract class Car : Vehicle
    {
        public void Wheels()
        {
            Console.WriteLine("Each car has wheels.");
        }
    }
}
