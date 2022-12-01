
using System;
namespace remainder
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the divident ");
            int divident= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor Number ");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = divident / divisor;
            int remainder = divident % divisor;
            Console.WriteLine("Quotient :" + quotient);
            Console.WriteLine("Remainder : " + remainder);
        }
    }
}