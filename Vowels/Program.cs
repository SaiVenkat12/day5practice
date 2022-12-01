using System;
namespace consoleapp1
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Alphabet :");
            char c1= char.Parse(Console.ReadLine());
            if (c1 == 'a' || c1 == 'A')
            {
                Console.WriteLine(c1 + " is a Vowel");
            }
            else if (c1 == 'e' || c1 == 'E')
            {
                Console.WriteLine(c1 + " is a Vowel");
            }
            else if (c1 == 'i' || c1 == 'I')
            {
                Console.WriteLine(c1 + " is a Vowel");
            }
            else if (c1 == 'o' || c1 == 'O')
            {
                Console.WriteLine(c1 + " is a Vowel");
            }
            else if (c1 == 'u' || c1 == 'U')
            {
                Console.WriteLine(c1 + " is a Vowel");
            }
            else 
            {
                Console.WriteLine(c1 + " is a Consonent");
            }
        }
    }
}