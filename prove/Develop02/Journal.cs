using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata;

class Journal
{
    public string _filename;
    public List<Entry> _entries = new List<Entry>();
    

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.DisplayEntry());
        }
    }



    public void SaveJournal(string _filename)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToFile());
            }
        }
    }

    public void ReadFiles(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            Entry displayE = new Entry(date, prompt, response);
            Console.WriteLine(displayE.DisplayEntry());
        }
    }
}