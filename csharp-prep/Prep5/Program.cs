using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int fav_number = int.Parse(Console.ReadLine());
        return fav_number;
    }

    static int PromptUserBirthYear()
    {
        Console.Write("Please enter the year you were born: ");
        int birth_year = int.Parse(Console.ReadLine());
        return birth_year;
    }

    static int SquareNumber(int num)
    {
        int num_squared = num * num;
        
        return num_squared;
    }

    static void DisplayResult(string name, int num_squared, int birth_year)
    {
        int year_old = 2026 - birth_year;

        Console.WriteLine($"{name}, the square of your number is {num_squared}");
        Console.WriteLine($"{name}, you will turn {year_old} this year.");
    }


    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int year = PromptUserBirthYear();
        int num_squared = SquareNumber(number);

        DisplayResult(name, num_squared, year);
    }
}