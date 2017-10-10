using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void CultureCompare(string name1, string name2)
        {
            var c1 = CultureInfo.GetCultureInfo(name1);
            var c2 = CultureInfo.GetCultureInfo(name2);

            Console.WriteLine("Название культуры\t\t{0}\t\t\t{1}", c1.EnglishName, c2.EnglishName);
            Console.WriteLine("Формат даты\t\t\t{0}\t{1}",
                c1.DateTimeFormat.LongDatePattern,
                c2.DateTimeFormat.LongDatePattern);
            Console.WriteLine("Формат времени\t\t\t{0}\t\t\t{1}",
                c1.DateTimeFormat.LongTimePattern,
                c2.DateTimeFormat.LongTimePattern);
            Console.WriteLine("Разделитель дробной части\t{0}\t\t\t{1}",
                c1.NumberFormat.NumberDecimalSeparator,
                c2.NumberFormat.NumberDecimalSeparator);
            Console.WriteLine("Разделитель групп разрядов\t{0}\t\t\t{1}",
                c1.NumberFormat.NumberGroupSeparator,
                c2.NumberFormat.NumberGroupSeparator);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Отличия в параметрах культур:");
            Console.WriteLine();
            CultureCompare("ru", "en");
            Console.WriteLine();
            CultureCompare("en", "");
            Console.WriteLine();
            CultureCompare("ru", "");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
