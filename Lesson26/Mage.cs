using System;

namespace Lesson26
{
    sealed class Mage : Character
    {
        public int mana;

        public Mage(string name, int life, int mana) : base (name, life)
        {
            this.mana = mana;
        }

        //new public void Movement()
        //{
        //    Console.WriteLine("Movement of a mage.");
        //}

        public override void Movement()
        {
            //base.Movement();
            Console.WriteLine("Movement of a mage.");
        }
    }
}
