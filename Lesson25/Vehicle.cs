using System;

namespace Lesson25
{
    abstract class Vehicle
    {
        public string Name { get; set; }

        public void Type()
        {
            Console.WriteLine("Each vehicle has a type.");
        }
    }
}
