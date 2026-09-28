using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        // Console.Write("What is the magic number? ");
        // int magicNum =int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int magicNum = rnd.Next(0,99);
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            int guessCount = 1;

            while(guess != magicNum)
            {
                if(guess < magicNum)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    guessCount +=1;
                }

                if(guess > magicNum)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    guessCount +=1;
                }
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} tries");

            Console.WriteLine("Would you like to play again? yes/no ");
            string playAgain
        }while();
    }
}