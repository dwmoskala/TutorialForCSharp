using System;
using System.Collections;

namespace Lesson21
{
    class Program
    {
        static void Main()
        {
            ArrayList list = new ArrayList();

            list.Add(2);
            list.Add("John");
            list.Add(new Car("Honda"));

            Console.WriteLine(list.Count);

            //Console.WriteLine(list[0]);

            //list.RemoveAt(1);
            //Console.WriteLine(list.Count);

            //list.Insert(1, "Alice");

            //list.Clear();
            //Console.WriteLine(list.Count);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
    }
}
