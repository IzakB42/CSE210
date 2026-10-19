class Reference
{
    private string _book;
    private int _chapter;
    private int[] _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse[0] = verse;
    }

    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse[0] = startverse;
        _verse[1] = endverse;
    }

    
}