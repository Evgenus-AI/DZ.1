using System;
using System.Security.Cryptography;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string code = "";
            for (int i = 0; i < 12; i++)
                code += Random.Shared.Next(10);
 
            Console.WriteLine($"Случайные цифры: {code}");
            Console.WriteLine($"Контрольная цифра: {CheckDigit(code)}");
 
            Console.Write("Введи 12 цифр: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Контрольная цифра: {CheckDigit(input)}");
        }
 
        static int CheckDigit(string code)
        {
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                int digit = code[i] - '0';
 
                if (i % 2 == 0)
                    sum += digit;
                else
                    sum += digit * 3;
            }
 
            return (10 - sum % 10) % 10;
        }
    }
}