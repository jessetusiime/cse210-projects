using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;
        int counter = 0;

        while (guess != number)
        {
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            counter++;

        if (guess > number)
        {
            Console.WriteLine("Higher");
        }

        else if (guess < number)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine($"You guessed it, The magic number is {number}");
            Console.WriteLine($"You guessed it in {counter} tries");
        }
    }    
    }
}