using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static bool IsScientific(string input)
        {
            return Regex.IsMatch(input, @"[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?");
        }

        static bool IsDefaultNumber(string input)
        {
            return Regex.IsMatch(input, @"^[eE*]?[+-]?([0-9]*[.])?[0-9]+");
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            
            if (IsDefaultNumber(input))
                Console.WriteLine("Это число в обычной нотации");
            else if (IsScientific(input))
                Console.WriteLine("Это число в научной нотации");
            else
                Console.WriteLine("Это не число");

            Console.ReadKey();
        }
    }
}
