using System;
using System.Collections.Generic;

namespace Lesson22
{
    class Program
    {
        static void Main()
        {
            List<Car> list = new List<Car>
            {
                new Car("Honda"),
                new Car("BMW")
            };

            foreach (Car item in list)
            {
                Console.WriteLine(item.Name);
            }

            //Dictionary<int, string> dictionary = new Dictionary<int, string>
            //{
            //    { 1, "John" },
            //    { 7, "Alice" },
            //    { 5, "John" }
            //};

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}

            Console.ReadKey();
        }
    }
}
