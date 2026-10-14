using System.Security.Cryptography.X509Certificates;

class Menu
{
    public int ProcessMenu()
    {
        int response = 0;

        while (response >= 1 || response <= 4)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Create, Display, Save, and Read Journal Entries");
            Console.WriteLine("1. Create new journal new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save journal file");
            Console.WriteLine("4. Read journal from file");
            Console.WriteLine("5. Quit");

            
            response = int.Parse(Console.ReadLine());

            
                Journal j1 = new Journal();

            if (response == 1)
            {
                
                Entry newEntry = new Entry();
                newEntry.NewEntry();

                j1.AddEntry(newEntry);
                // Don't need to pass in a variable, can pass in the class 
                // instead since writeEntry updates the variables.
            }

            if (response == 3)
            {
                Console.WriteLine("Where would you like to save this to? (type filename, end with .txt):");
                j1._filename = Console.ReadLine();
                j1.SaveJournal();
            }

            if (response == )
            {
                j1.ReadFiles(_file);
            }
        }

        if (response == 5)
            {
                Console.WriteLine("Have a good day!");
            }
            
        return response;
    }
}