using System;

namespace Lesson27
{
    class Character : INormalAttack, IMagicAttack
    {
        void INormalAttack.Attack(int points)
        {
            Console.WriteLine($"Normal attack with {points} points.");
        }

        void IMagicAttack.Attack(int points)
        {
            Console.WriteLine($"Magic attack with {points} points.");
        }

        public void HeavyAttack(int points)
        {
            Console.WriteLine($"Heavy attack with {points} points.");
        }
    }
}
