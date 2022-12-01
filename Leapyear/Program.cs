using System;
namespace leapyear
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year :");
            int x = int.Parse(Console.ReadLine());

            if ((x >= 1000) && (x < 10000))
            {
                Console.WriteLine("{0} is a 4 digit number", x);
                if ((x % 100 != 0) && (x % 4 == 0) || (x % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year", x);
                }
                else
                {
                    Console.WriteLine("{0} is Not a Leap Year", x);
                }
            }
            else
            {
                Console.WriteLine("{0} is Not a 4 digit number", x);
            }

        }
    }
}