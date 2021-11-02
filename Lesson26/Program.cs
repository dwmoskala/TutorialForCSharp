using System;

namespace Lesson26
{
    class Program
    {
        static void Main()
        {
            Mage mage = new Mage("Merlin", 20, 50);
            Console.WriteLine($"Name: {mage.name}\nLife: {mage.life} points\nMana: {mage.mana} points");

            Console.ReadKey();
        }
    }
}
