using System;
using System.Globalization;

namespace Lesson20
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CultureInfo.CurrentCulture.Name);

            var cultureInfoTab = CultureInfo.GetCultures(CultureTypes.AllCultures);

            //foreach (var item in cultureInfoTab)
            //{
            //    Console.WriteLine($"{item.Name}: {item.NumberFormat.NumberDecimalSeparator}");
            //}

            int a = -10;
            double b = 3.14;

            //Console.WriteLine($"{a}\n{b}");

            //var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            //newCulture.NumberFormat.NumberDecimalSeparator = ":";
            //newCulture.NumberFormat.NegativeSign = "minus ";
            //CultureInfo.CurrentCulture = newCulture;

            //Console.WriteLine($"{a}\n{b}");

            Console.ReadKey();
        }
    }
}
