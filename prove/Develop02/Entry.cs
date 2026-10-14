using System.Data;

class Entry
{
    public string _datetime;
    public string _response;

    public string _prompt;

    public Entry()
    {
        _datetime = "";
        _prompt = "";
        _response = "";
    }
    public Entry(string date, string prompt, string response)
    {
        _datetime = date;
        _prompt = prompt;
        _response = response;
    }

    public void NewEntry()
    {
        GetDateTime();
        
        Prompts _prompts = new Prompts();
        _prompts._MakePrompts();
        _prompt = _prompts._RandomPrompt();
        Console.WriteLine(_prompt);

        _response = Console.ReadLine();
    }

    public void GetDateTime()
    {
        DateTime currentTime = DateTime.Now;
        _datetime = currentTime.ToShortDateString();
    }

    public string ToFile()
    {
        GetDateTime();
        return $"{_datetime}#{_prompt}#{_response}";
    }
    public string DisplayEntry()
    {
        GetDateTime();
        return $"Date: {_datetime}\tPrompt: {_prompt}\nResponse: {_response}";
    }
}