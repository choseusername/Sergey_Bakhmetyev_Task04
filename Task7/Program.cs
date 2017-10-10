using System;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static int CountTimeInText(string text) => Regex.Matches(text, @"([0-9]|0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]").Count;

        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string str = Console.ReadLine();
            Console.WriteLine("Время в тексте присутствует {0} раз.", CountTimeInText(str));
            Console.ReadKey();
        }
    }
}
