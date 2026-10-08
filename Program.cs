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
            Console.WriteLine(a);
            Console.WriteLine($"Привет, {a}");
        }
    }
}