using System;
namespace PowerofTwo
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number lessthan 31 :");
            int n = int.Parse(Console.ReadLine());
            int a = 1;

            if (n < 31)
            {
                for (int i = 0; i < n; i++)
                {
                    a = a * 2;
                }
                Console.WriteLine("The 2 power of {0} is {1}", n,a);
            }
            else
            {
                Console.WriteLine("The Number {0} is not acceptable.", n);
            }

        }
    }
}