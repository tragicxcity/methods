using System;

namespace methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is you name");
            var name = Console.ReadLine();

            Console.WriteLine($"{name}, welcome to your very own cyber adventure");

            TwoChoices();

        }

        private static void TwoChoices()
        {

            string input = "";
            Console.WriteLine("What will you do first a or b");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.WriteLine("a. turn on pc");
            }
            else
            {
                Console.WriteLine("b. turn on montior");
            }

        }
    }
}