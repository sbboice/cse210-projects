using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1,11);

        int guess = -1;

        while (guess != answer)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (answer > guess)
            {
                Console.WriteLine("Too low.");
            }

            else if (answer < guess)
            {
                Console.WriteLine("Too high.");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        
  


    }
}