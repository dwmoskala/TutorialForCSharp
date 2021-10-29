using System;

namespace Lesson01
{
    class Program
    {
        static void Main()
        {
            var anyVariable = "I can be any type.";
            int integerNumber = 2147483647;
            string text = "Plain text.";
            char singleCharacter = 'a';
            bool boolean = true;
            byte singleByte = 255;
            short shortIntegerNumber = 32767;
            long longIntegerNumber = 9223372036854775807;
            decimal decimalNumber = 7.9228162514264337593543950335m;
            float floatNumber = 3.402823E+38f;
            double doubleNumber = 1.79769313486232E+307;
            uint unsignedInteger = 4294967295;
            ushort unsignedShort = 65535;
            ulong unsignedLong = 18446744073709551615;
            const double PI = 3.14;

            Console.WriteLine(anyVariable);
            Console.Write(PI);
            Console.ReadKey();
        }
    }
}
