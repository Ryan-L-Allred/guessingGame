using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int SuperSecretInt = 42;
            Console.WriteLine("Hello user! Guess the secret number,n");
            Console.Write("What's you guess? input it here:");
            string UserAnswer = Console.ReadLine();
            
            if (int.Parse(UserAnswer) == SuperSecretInt)
            {
                Console.WriteLine($"Wowzers! {UserAnswer} is correct!");
            }
            else
            {
                Console.WriteLine("nahhhh that's wrong. Try again?");
            }
        }
    }
}         
        
            
       
