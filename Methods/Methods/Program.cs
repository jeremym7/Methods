using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //USer inputs their name
            Console.WriteLine("Please enter your name: ");

            string input = Console.ReadLine();

            UName(input);
        }

        private static void UName(string input) 
        {
            //Shows user hello and their name thei inputed
            Console.WriteLine("Hello " + input + "!");
        }
    }
}
