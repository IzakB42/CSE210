using System;

class Program
{

    static int GetMagicNumber()
    {
        Random rnd = new Random();
        int magicNum = rnd.Next(0,99);

        return magicNum;
    }
    static void Main(string[] args)
    {
        int guess = 0;

        string playAgain = "yes";

        // Console.Write("What is the magic number? ");
        // int magicNum =int.Parse(Console.ReadLine());

        
        do
        {
            int magic = GetMagicNumber();

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            int guessCount = 1;

            while(guess != magic)
            {
                if(guess < magic)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    guessCount +=1;
                }

                if(guess > magic)
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
            playAgain = Console.ReadLine();
        }while(playAgain == "yes");
    }
}