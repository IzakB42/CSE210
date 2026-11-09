using System.Runtime.InteropServices;

class Load
{
    private int i =0;
    private int _number;
    private string _filename;
    private Reference _ref;
    private Scripture _script;

    public Load(string file)
    {
        _filename = file;
    }
    public void ReadFromFile()
    {
        Console.Clear();

        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            i++;
            Reference tempref = FormatRefFromFile(line);
            Console.Write($"{i}. ");
            tempref.Display();
            Console.WriteLine();
        }

        Console.Write("Type the number of the scripture to memorize: ");
        string choice = Console.ReadLine();
        try
        {
            _number = int.Parse(choice)-1;
            if(_number <= i)
            {
                string line = lines[_number];
                _ref = FormatRefFromFile(lines[_number]);
                _script = FormatFromFile(line);

                // LAST THING TO DO!!! YOU GOT THIS!!!
                // Find a way to set string text to line parts[4 or 5 (depending on multi verse)]
                // through the last entry in the line. In FormatFromFile method

                _script.SetChoice(1);
                _script.Memorize();
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Please enter a valid number");
            choice = Console.ReadLine();
        }
    }
    private Reference FormatRefFromFile(string line)
    {
        Reference tempRef;
        string[] parts = line.Split('#');
        bool multi = bool.Parse(parts[0]);
        string book = parts[1];
        int chapter = int.Parse(parts[2]);

        if (multi)
            {
                int startVerse = int.Parse(parts[3]);
                int endVerse = int.Parse(parts[4]);

                tempRef = new Reference(book, chapter, startVerse, endVerse);
            }
            else
            {
                int verse = int.Parse(parts[3]);

                tempRef = new Reference(book, chapter, verse);
            }

        return tempRef;
    }
    private Scripture FormatFromFile(string line)
    {
        Scripture tempScript;
        string[] parts = line.Split('#');      
        bool multi = bool.Parse(parts[0]);
        string text;

        if (multi)
        {
            text = $"{parts[5]}";
            for(int i=4; i<= parts.Length; i++)
            {
                if(i>5)
                {
                    text = $"{text}{parts[i]}";
                }
            }
        }
        else
        {
            text = $"{parts[4]}";

            for(int i=4; i<= parts.Length; i++)
            {
                if(i>5)
                {
                    text = $"{text}{parts[i]}";
                }
            }
        }
        tempScript = new Scripture(_ref, text);
        
        return tempScript;
    }
}