using System;

namespace Lesson26
{
    abstract class Character
    {
        public string name;
        public int life;

        public Character(string name, int life)
        {
            this.name = name;
            this.life = life;
        }

        //public virtual void Movement()
        //{
        //    Console.WriteLine("Movement of a character.");
        //}

        public abstract void Movement();
    }
}
