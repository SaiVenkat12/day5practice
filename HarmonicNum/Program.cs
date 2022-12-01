using System;
namespace HarmonicNum
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Nth Term of Harmonic : ");
            int n = int.Parse(Console.ReadLine());
            double harmonic = 0;
            if (n != 0)
            {
                for (int i = 1; i <=n; i++)
                {
                    harmonic += (float)1 / i;
                }
                Console.WriteLine("The Sum of Nth term in Harmonic Series is" + harmonic);
            }
            else
            {
                Console.WriteLine("The term {0} is incorrect", n);
            }
        }
    }
}