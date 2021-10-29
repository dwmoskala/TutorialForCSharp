using System;

namespace Lesson07
{
    class Program
    {
        static void Main()
        {
            //1. Draw a rectangle from *, which has height x and width y (both integer). Values are entered by user.
            //Answer1.DrawRectangle(); //uncomment to check how ti should works.

            //2. Computer draws a number from 1 to 100 (integer). User tries to guess the number. If computer's number is higher or lower than user's guess, show info. If user guessed, show info.
            //Answer2.GuessTheNumber(); //uncomment to check how it should works.

            int randomNumber = new Random().Next(1, 100); //variable that contains random number from 1 to 100.
        }
    }
}
