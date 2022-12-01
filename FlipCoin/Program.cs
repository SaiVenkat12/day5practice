using System;
namespace FlipCoin
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many times you want to flip the coin:");
            int flips = int.Parse(Console.ReadLine());
            int heads = 0;
            int tails = 0;
                for (int i = 0; i > flips; i++)
                {
                    var random = new Random();
                    int n = random.Next(0,2);
                    Console.WriteLine("{0}",n);
                    if (n == 0)
                    {
                        heads++;
                    }
                    else
                    {
                        tails++;
                    }
                }
                float headspercent = heads * 100 / flips;
                float tailspercent = 100 - headspercent;
                Console.WriteLine("heads {0}", heads);
                Console.WriteLine("Heads percentage={0}", headspercent);
                Console.WriteLine("Tails percentsge={0}", tailspercent);

            

        }
    }
}