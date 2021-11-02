using System;

namespace Lesson26
{
    class Mage : Character
    {
        public Mage(string name, int life, int mana) : base (name, life)
        {
            this.mana = mana;
        }

        public int mana;
    }
}
