using System;
namespace evenodd
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("{0} is a Even Nummber", x);
            }
            else
            {
                Console.WriteLine("{0} is a Odd Number", x);
            }
        }
    }
}