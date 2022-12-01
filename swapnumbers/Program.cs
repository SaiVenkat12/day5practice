using System;
namespace swapnumbers
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of A :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of B :");
            int b = int.Parse(Console.ReadLine());
            int temp = 0;
            temp= a;
            a= b;
            b= temp;
            Console.WriteLine("The Values after Swap");
            Console.WriteLine("The value of A = " + a);
            Console.WriteLine("The value of B = " + b);

        }
    }
}