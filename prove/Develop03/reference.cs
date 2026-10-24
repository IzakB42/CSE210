using System.ComponentModel.DataAnnotations;

class Reference
{
    private bool _mulitVerse;
    private string _book;
    private int _chapter;
    private int[] _verse = new int[2];

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse[0] = verse;
        _mulitVerse = false;
    }

    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse[0] = startverse;
        _verse[1] = endverse;
        _mulitVerse = true;
    }

    private string Format()
    {
        string returnRef;
        if(_verse[1] == 0)
        {
            returnRef = $"{_book} {_chapter}:{_verse[0]}";
        }
        else
        {
            returnRef = $"{_book} {_chapter}:{_verse[0]}-{_verse[1]}";
        }
        
        return returnRef;
    }
    public void Display()
    {
        Console.Write(Format());
    }

    public string GetRef()
    {
        return Format();
    }

    public string FileFormat()
    {
        string returnRef;
        if(_verse[1] == 0)
        {
            returnRef = $"{_mulitVerse}#{_book}#{_chapter}#{_verse[0]}#";
        }
        else
        {
            returnRef = $"{_mulitVerse}#{_book}#{_chapter}#{_verse[0]}#{_verse[1]}#";
        }
        
        return returnRef;
    }
}