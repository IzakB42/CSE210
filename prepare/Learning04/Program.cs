using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment a1 = new Assignment("Smelly Belly", "PE");
        // Console.WriteLine(a1.GetSummary());
        
        // MathAssignment ma1 = new MathAssignment("Hemerbap", "Karate", "4.2", "9-999");
        // Console.WriteLine(ma1.GetSummary());
        // Console.WriteLine(ma1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Shmebadoo", "Calculator class", "The Invention of the Calculator");
        Console.WriteLine(w1.GetWritingInformation());

    }
}