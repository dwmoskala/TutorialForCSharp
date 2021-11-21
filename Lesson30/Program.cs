using System;

namespace Lesson30
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine(Division(5));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Do not divide by 0! " + e.Message);
            }
            catch (DivideByFiveException e)
            {
                Console.WriteLine("Exception with dividing by 5.\n" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong! " + e.Message);
            }
            finally
            {
                Console.WriteLine("Always will be done.");
            }

            Console.ReadKey();
        }

        static float Division(int a)
        {
            if (a == 5)
            {
                throw new DivideByFiveException("An error occured: ");
            }

            return 10 / a;
        }
    }
}
