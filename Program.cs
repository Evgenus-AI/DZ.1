using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 11;
            int c = (a+b)/2;
            double d = Math.Sqrt(a*b);
            Console.WriteLine($"Среднее арифметическое: {c}");
            Console.WriteLine($"Среднее геометрическое: {d}");
        }
    }
}