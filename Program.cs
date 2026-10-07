using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            (a, b, c) = (b, c, a);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            (a,b,c) = (c,a,b);
            Console.WriteLine(a);  
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}