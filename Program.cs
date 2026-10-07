using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10;
            int x2 = 20;
            int y1 = 10;
            int y2 = 20;
            double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine(d);
        }
    }
}