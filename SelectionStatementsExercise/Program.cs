using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 100);
            int userInput;
            do
            {
                Console.WriteLine("Try to guess my favorite number between 1 & 100");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too Lowwwww!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too High!");
                }
                else if (userInput == favNumber)
                {
                    Console.WriteLine("That's correct!");
                }
                else
                {
                    Console.WriteLine("nevermind");
                }
            } while (favNumber != userInput);
        }
    }
}
