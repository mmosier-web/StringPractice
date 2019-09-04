using System;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");

            string firstName;
            firstName = Console.ReadLine();

            Console.WriteLine("your name is" + firstName);

        }
    }
}