using System;
using System.Security.Cryptography;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int  a = int.Parse(Console.ReadLine());
            if (a<999)
            {
                Console.WriteLine("Число должно быть больше чем 999");
                return;
            }

            int s = (a / 100)%10;
            int t = (a/1000)%10;
            Console.WriteLine(t);
            Console.WriteLine(s);

        }
    }
}