using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! Guess the secret number,n");
            Console.Write("What's you guess? input it here:");
            
            string UserAnswer = Console.ReadLine();
            
            Console.Write(UserAnswer);
            // Console.ReadLine();
        }
    }
}
