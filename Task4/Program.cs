using System.Text;
using System.Diagnostics;
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cравнительный анализ скорости работы классов String и StringBuilder для операции сложения:

            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100000;

            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopwatch.Stop();
            Console.WriteLine("Время выполнения участка кода работы с классом String "
                + stopwatch.ElapsedMilliseconds + "ms");

            stopwatch.Restart();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopwatch.Stop();
            Console.WriteLine("Время выполнения участка кода работы с классом StringBuilder "
                + stopwatch.ElapsedMilliseconds + "ms");

            Console.ReadKey();
        }
    }
}
