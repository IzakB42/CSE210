

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
        // _hidden Setter
        _hidden = true;
    }

    public bool IsHidden()
    {
        // _hidden Getter
        return _hidden;
    }

    public void Display()
    {
        // Console Display
        Console.Write($"{GetString()} ");
    }

    public string GetString()
    {
        // returns list of words back as string, hidden ones as underscores
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

    public string GetFileString()
    {
        string returnString = "";
        if(_hidden)
        {
            _hidden=false;
        }
        returnString= $"{_word}#";

        return returnString;
    }
}