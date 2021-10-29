using System;

namespace Lesson07
{
    class Answer2
    {
        public static void GuessTheNumber()
        {
            var randomNumber = new Random().Next(1, 100);
            int userNumber;

            do
            {
                Console.Write("Guess the number: ");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber > randomNumber)
                {
                    Console.WriteLine("Too high!\n");
                }
                else if (userNumber < randomNumber)
                {
                    Console.WriteLine("Too low!\n");
                }
                else
                {
                    Console.WriteLine($"Correct! The number is {randomNumber}.");
                }
            } while (userNumber != randomNumber);

            //int userNumber = 0;

            //for (; userNumber != randomNumber;)
            //{
            //    Console.Write("Guess the number: ");
            //    userNumber = int.Parse(Console.ReadLine());

            //    if (userNumber > randomNumber)
            //    {
            //        Console.WriteLine("Too high!\n");
            //    }
            //    else if (userNumber < randomNumber)
            //    {
            //        Console.WriteLine("Too low!\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Correct! The number is {randomNumber}.");
            //    }
            //}

            Console.ReadKey();
        }
    }
}
