using System;

namespace flipCoinPercentage
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int HEAD = 1;
            Random random = new Random();
            //Computation
            int flip = random.Next(0, 2);
            if (flip == HEAD)
            {
                Console.WriteLine("HEAD");
            }
            else
            {
                Console.WriteLine("Tail");
            }
        }
    }
}
