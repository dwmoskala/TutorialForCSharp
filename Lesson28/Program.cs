using System;

namespace Lesson28
{
    class Program
    {
        static void Main()
        {
            Point point1;
            point1.x = 5;
            point1.y = 10;

            //Point point2;
            //point2 = point1;
            //point2.x = 7;

            //Point point3 = new Point(3, 4);

            //Point point4 = point1 + point2;

            Console.WriteLine($"Point 1 ({point1.x}, {point1.y})");
            //Console.WriteLine(point1.CenterDistance());

            //Console.WriteLine($"Point 2 ({point2.x}, {point2.y})");
            //Console.WriteLine($"Point 3 ({point3.x}, {point3.y})");
            //Console.WriteLine($"Point 4 ({point4.x}, {point4.y})");

            Console.ReadKey();
        }
    }
}
