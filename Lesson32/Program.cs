using System;
using System.IO;

namespace Lesson32
{
    class Program
    {
        static void Main()
        {
            string path = "TextFile.txt";
            StreamWriter sw;

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("Text file has been created.");
            }
            else
            {
                sw = new StreamWriter(path, true);
            }

            Console.Write("Write text: ");
            string textToSave = Console.ReadLine();
            sw.WriteLine(textToSave);
            sw.Close();

            StreamReader sr = File.OpenText(path);
            string textLine;
            int i = 1;
            Console.WriteLine("\nContent:");        
            while ((textLine = sr.ReadLine()) != null)
            {
                Console.WriteLine($"Line {i++}: {textLine}");
            }
            sr.Close();

            Console.ReadKey();
        }
    }
}
