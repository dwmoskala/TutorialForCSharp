using System;

namespace Lesson27
{
    class Program
    {
        static void Main()
        {
            Character character = new Character();
            INormalAttack normalAttack = character;
            IMagicAttack magicAttack = character;
            normalAttack.Attack(5);
            magicAttack.Attack(10);
            character.HeavyAttack(20);

            Console.ReadKey();
        }
    }
}
