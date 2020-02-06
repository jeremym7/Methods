using System;

namespace Methods
{
    class Program
    {
        private static string UName;

        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");

            string input = Console.ReadLine();

            UName = input; 

            if (System.Text.RegularExpressions.Regex.IsMatch(input, "[a-zA-Z]")) 
            {
                Console.WriteLine("Hello " + UName + "!");
            }

            else 
            {
                Console.WriteLine("Please enter alphabetical letters only, and try again.");
            }
        }
    }
}
