
using System;
namespace largestnum
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st Number ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Number ");
            int z = int.Parse(Console.ReadLine());
            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("{0} is greatest ", x);
                }
                else
                {
                    Console.WriteLine("{0} is greatest", z);
                }
            }
            else if (y > z)
            {
                Console.WriteLine("{0} is greatest", y);
            }
            else
            { Console.WriteLine("{0} is greatest", z);
            }
            
        }
    }
}