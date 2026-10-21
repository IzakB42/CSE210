// converts scripture into a list of the word class separated by spaces 

// include a display scripture class

// i++
// if i < List<words>.Count then run hide word.

class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private string _text;

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

        Console.WriteLine($"{_reference.GetRef()}");
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    public void HideSomeWords()
    {
        
        for(int i=0; i<=3; i++)
        {
            // run the Hide() function for a random word in _words
            Random r1 = new Random();

        }
    }

}