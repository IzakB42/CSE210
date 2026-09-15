using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";

        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int numGrade = int.Parse(response);

        if (numGrade >= 90)
        {
            letter = "A";
        }

        else if (numGrade >= 80)
        {
            letter = "B";
        }
        else if (numGrade >= 70)
        {
            letter = "C";
        }
        else if (numGrade >= 60)
        {
            letter = "D";
        }
        else if (numGrade < 60)
        {
            letter = "F";
        }
        
        if (numGrade >= 70)
        {
            Console.WriteLine($" Congradulations! You passed with a {letter}");
        }
        else
        {
            Console.WriteLine($"Dang it! you got a {letter}. Better luck next time!");
        }
        
    }
}