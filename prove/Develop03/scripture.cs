// converts scripture into a list of the word class separated by spaces 

// include a display scripture class

// i++
// if i < List<words>.Count then run hide word.

using System.Security.Cryptography;

class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _reference = new Reference(bookName, chapter, verse);
        _words = ConvertToWords(text);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(bookName, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

    public Scripture(Reference currentRef, string text)
    {
        _reference = currentRef;
        _words = ConvertToWords(text);
    }

    public void Memorize()
    {
        Console.Clear();
        Display();
        bool keepGoing = false;
        string tempAnswer = "test";

        do{
            keepGoing = false;
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            tempAnswer = Console.ReadLine();

            if (tempAnswer == "")
            {
                keepGoing = true;
            }
            else
            {
                while(keepGoing=false && tempAnswer!= "quit")
                {
                    Console.WriteLine("Please enter a valid input");
                    tempAnswer = Console.ReadLine();
                }
                    
            }

            if(keepGoing)
            {
                HideSomeWords();
                Display();
            }

        }while(tempAnswer != "quit" && NumberofUnhiddenWords()!=0);
        Console.WriteLine();
        Console.WriteLine("Have a good day!");
    }
    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();

        string[] words = text.Split(' ');
        foreach(string word in words)
        {
            Word tempword = new Word(word);
            tempWords.Add(tempword);
        }

        return tempWords;
    }
    public void Display()
    {

        Console.Write($"{_reference.GetRef()} ");
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    private void HideSomeWords()
    {
        int number_to_hide = 3;
        if(NumberofUnhiddenWords()<= number_to_hide)
        {
            number_to_hide = NumberofUnhiddenWords();
        }
        for(int i=0; i<number_to_hide;)
        {
            // run the Hide() function for a random word in _words
            // also clears the console
            Random rnd = new Random();
            int index = rnd.Next(_words.Count);
            Word temp = _words[index];
            if (!temp.IsHidden())
            {
                _words[index].Hide();
                i++;
            }
            

            Console.Clear();

        }
    }

    // nuumber of unhidden words returns int
    // for loop add 1 for each unhidden word in list

    private int NumberofUnhiddenWords()
    {
        int num = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                num++;
            }
        }

        return num;
    }


}