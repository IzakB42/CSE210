using System;

class Program
{

    static double AddNumbers(double x, int y)
    {
        return x + y;
    }

    static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Welcome {name}, pleased to meet you.");
    }

    static void Main(string[] args)
    {   
        DisplayGreeting("Jimmy Jose");
        double answer = AddNumbers(12.234, 10);
        Console.WriteLine(answer);

        // bool done;

        // DO WHILE LOOP VERSION. RUNS ONCE BEFORE CHECKING CRITERIA TO RUN AGAIN
        
        // do
        // {
        //     Console.Write("Are we done (y/n): ");
        //     done = Console.ReadLine().ToLower() == "y";
        // }while (! done);


        // WHILE LOOP VERSION. IF ENTRY STRATEGY ISN'T CORRECT, WON'T RUN

        // bool done = false;

        // while (! done)
        // {
        //     Console.Write("Are we done (y/n): ");
        //     done = Console.ReadLine().ToLower() == "y";
        // }

        // for(int i = 100; i > -100; i-=42) 
        // {
        //     Console.WriteLine(i);
        // }


        // List<string> myFriends = ["Bob", "Jose", "Juanita"];
        // List<string> nombres = new List<string>();
        // myFriends.Add("Giovanni");
        // myFriends.AddRange("BillyBobJumbo", "Shmebulock");



    }
}