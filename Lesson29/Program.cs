using System;

namespace Lesson29
{
    class Program
    {
        enum Seasons : sbyte
        {
            Spring = 15,
            Summer = 25,
            Autumn = 10,
            Winter = -5
        }

        static void Main()
        {
            Seasons season = Seasons.Spring;
            
            Console.WriteLine(season);
    
            //Console.WriteLine(Seasons.Summer);
            
            //Console.WriteLine((int)season);
           
            //season = (Seasons)10;
            //Console.WriteLine(season);

            Console.ReadKey();
        }
    }
}
