using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите большее основание");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите менешее основание");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту");
            int h = int.Parse(Console.ReadLine());
            int x = (a - b) / 2;
            double c = Math.Sqrt(h * h + x * x);
            int c1 = Convert.ToInt32(c);
            int p = a + b + 2 * c1;
            Console.WriteLine($"Периметр трапеции равен: {p}");
        }
    }
}