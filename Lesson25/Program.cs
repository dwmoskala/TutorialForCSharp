using System;

namespace Lesson25
{
    class Program
    {
        static void Main()
        {
            Sedan sedan1 = new Sedan();
            sedan1.Name = "Honda";

            Console.WriteLine(sedan1.Name);
            sedan1.Type();
            sedan1.Wheels();
            sedan1.Doors();

            Console.ReadKey();
        }
    }
}
