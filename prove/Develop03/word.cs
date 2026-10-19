

// Hide word method
// autoreplaces the word with underscores
// random int from 1-3
// run for loop 1-3 times
// for loop hides 1 word in List<words>.Count

// Method to check if words are hidden, return boolean true false, 
// when all are hidden stop hiding words.

class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Display()
    {
        Console.Write($"{GetString()} ");
    }

    public string GetString()
    {
        string returnString = "";
        if (_hidden)
        {
            for(int i = 0; i < _word.Length; i++)
            {
                returnString += '_';
            }
        }
        else
        {
            returnString = _word;
        }
        return returnString;
    }
}