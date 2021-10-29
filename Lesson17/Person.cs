using System;

namespace Lesson17
{
    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value > 0 && value < 150)
                    age = value;
                else
                    age = 0;
            }
        }

    }
}
