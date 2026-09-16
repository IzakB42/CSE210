using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Console.Write("What is the magic number? ");
        int magicNum =int.Parse(Console.ReadLine());

        Console.Write("What is your guess?");
        guess = int.Parse(Console.ReadLine());

        do
        {
            if(guess < magicNum)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }

            if(guess > magicNum)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }
        }while(guess != magicNum);

        Console.WriteLine("You guessed it!");
    }
}