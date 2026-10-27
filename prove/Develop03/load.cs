class Load
{
    private int i =0;
    private int _number;
    private string _filename;
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
            Reference tempref = FormatFromFile(line);
            Console.Write($"{i}. ");
            tempref.Display();
            Console.WriteLine();
        }

        Console.Write("Type the number of the scripture to memorize: ");
        string choice = Console.ReadLine();
        try
        {
            _number = int.Parse( choice);
            if(_number <= i)
            {
                string line = lines[i];
                Reference finalRef = FormatFromFile(line);
                _script = new Scripture(finalRef, )
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Please enter a valid number");
            choice = Console.ReadLine();
        }
    }

    private Reference FormatFromFile(string line)
    {
        Reference tempref;
        string[] parts = line.Split('#');
            
            bool multi = bool.Parse(parts[0]);
            string book = parts[1];
            int chapter = int.Parse(parts[2]);
            
            if (multi)
            {
                int startVerse = int.Parse(parts[3]);
                int endVerse = int.Parse(parts[4]);

                tempref = new Reference(book, chapter, startVerse, endVerse);
            }
            else
            {
                int verse = int.Parse(parts[3]);
                tempref = new Reference(book, chapter, verse);
            }
        
        return tempref;
    }
}