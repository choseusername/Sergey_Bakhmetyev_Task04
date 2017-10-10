using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {

        static float GetAvgWordLength(string input)
        {
            float sum = 0.0f;
            // [\p{P}] Соответствует всем знакам препинания.
            input = Regex.Replace(input, @"[\p{P}]", " ");
            string[] strings = input.Split(' ');
            foreach (var str in strings)
                sum += str.Length;
            return sum / strings.Length;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите текстовую строку: ");
            string input = Console.ReadLine();
            Console.WriteLine("Средняя длина слова во введенной текстовой строке: {0}", GetAvgWordLength(input));
            Console.ReadKey();
        }
    }
}
