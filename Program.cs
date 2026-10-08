using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка! Число должно быть трехзначным.");
                return;
            }
            int last = number % 10;  
            int fisrt= number / 10;  
            int result = (last * 100) + fisrt;
            Console.WriteLine($"Полученное число: {result}");
        }
    }
}