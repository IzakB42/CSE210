using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Word w1 = new Word("Balooga");
        // w1.Display();
        // Console.WriteLine(w1.GetFileString());

        // w1.Hide();
        // w1.Display();

        // Reference r1 = new Reference("alma", 4, 27);
        // r1.Display();
        // string test = r1.FileFormat();
        // Console.WriteLine(test);

        // Reference r2 = new Reference("3 Nephi", 17, 5, 8);
        // r2.Display();
        // string test2 = r2.FileFormat();
        // Console.Write(test2);

        

        // string text = "15 And O how beautiful upon the mountains were their feet! 16 And again, how beautiful upon the mountains are the feet of those that are still publishing peace! 17 And again, how beautiful upon the mountains are the feet of those who shall hereafter publish peace, yea, from this time henceforth and forever!";
        // Scripture s2 = new Scripture("Mosiah", 15, 15, 17, text);
        // s2.Memorize();
        Console.Clear();
        Console.WriteLine("Which scripture would you like to memorize today?");
        Console.WriteLine("1. Get scripture from file.");
        Console.WriteLine("2. Input a new scripture.");
        Console.Write("Enter a option: ");
        int response = int.Parse(Console.ReadLine());

        while (response != 1 && response != 2)
            {
                Console.Write("Please choose a valid input: ");
                response = int.Parse(Console.ReadLine());
            }
        if (response ==1)
        {
            Load l1 = new Load("scripture_list.txt");
            l1.ReadFromFile();
        }

        if (response ==2)
        {
            //Replace the inputs on the next line with the new scripture!
            // Scripture(book, chapter, verse, text)
            // Or Scripture(book, chapter, start verse, end verse, text)

            Scripture s1 = new Scripture("1 Nephi", 2, 15, "And my father dwelt in a tent.");
            s1.Memorize();
        }
    }
}