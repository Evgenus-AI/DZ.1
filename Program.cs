using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            (a, b) = (b, a);
            Console.WriteLine(a); 
            Console.WriteLine(b);

        }
    }
}