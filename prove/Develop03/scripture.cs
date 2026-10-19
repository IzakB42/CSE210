// converts scripture into a list of the word class separated by spaces 

// include a display scripture class

// i++
// if i < List<words>.Count then run hide word.

class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private string _text;

    public void Display()
    {

        Console.WriteLine($"{_reference.GetRef()}");
        Console.Write($"scripture text");
    }

    public void HideSomeWords()
    {
        
        for(int i=0; i<=3; i++)
        {
            // run the Hide() function for a random word in _words
        }
    }

}