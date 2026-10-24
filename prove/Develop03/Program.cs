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

        Scripture s1 = new Scripture("1 Nephi", 2, 15, "And my father dwelt in a tent.");
        s1.Memorize();

        // string text = "15 And O how beautiful upon the mountains were their feet! 16 And again, how beautiful upon the mountains are the feet of those that are still publishing peace! 17 And again, how beautiful upon the mountains are the feet of those who shall hereafter publish peace, yea, from this time henceforth and forever!";
        // Scripture s2 = new Scripture("Mosiah", 15, 15, 17, text);
        // s2.Memorize();

    }
}