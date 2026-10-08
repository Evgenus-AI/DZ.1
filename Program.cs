using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d = 543;
            int s = 130;
            int k = 130;
            int c1 = d / k;
            int c2 = s / k;
            int rep = c1 * c2;

            Console.WriteLine($"Можно отрезать квадратов: {rep}");
        }
    }
}