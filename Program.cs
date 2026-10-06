using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {

                int randomNumber = random.Next(1, 101);
                Console.WriteLine(randomNumber);
            }
        }
    }
}