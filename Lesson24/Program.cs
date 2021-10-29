using System;
using System.Linq;

namespace Lesson24
{
    class Program
    {
        static void Main()
        {
            string s1 = "Program";
            String s2 = new string("Program".ToArray());

            Console.WriteLine(s1 == s2);
            //Console.WriteLine(s1.Equals(s2));

            //Car car1 = new Car("BMW", 2005);
            //Car car2 = new Car("BMW", 2005);

            //Console.WriteLine(car1 == car2);
            //Console.WriteLine(car1.Equals(car2));

            Console.ReadKey();
        }
    }
}
