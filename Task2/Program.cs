using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static string DoublesFirstAllCharactersSecond(string s1, string s2)
        {
            foreach (char c in new HashSet<char>(s2.ToCharArray()))
                s1 = s1.Replace(c.ToString(), c.ToString() + c);
            return s1;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string s1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string s2 = Console.ReadLine();
            Console.Write("Результирующая строка: {0}",
                DoublesFirstAllCharactersSecond(s1, s2));

            Console.ReadKey();
        }
    }
}
