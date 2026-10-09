using System;
using System.Security.Cryptography;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string a = Console.ReadLine();
            Console.WriteLine($"Привет, {a}");
            string b = Console.ReadLine();
            Console.WriteLine("Да");
            string c = Console.ReadLine();
            Console.Write("Нет");
            Thread.Sleep(5000);
            ConsoleColor[] colors = Enum.GetValues<ConsoleColor>();
            ConsoleColor color = colors[Random.Shared.Next(colors.Length)];
            Console.ForegroundColor = color;
            Console.WriteLine(", но могу показать");
        }
    }
}