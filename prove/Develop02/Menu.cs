using System.Security.Cryptography.X509Certificates;

class Menu
{
    public int ProcessMenu()
    {
        int response = 0;

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");

        Journal j1 = new Journal();

        do
        {
            Console.WriteLine("1. Create new journal entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Read journal from file");
            Console.WriteLine("5. Quit");


            response = int.Parse(Console.ReadLine());

            while (response != 1 && response != 2 && response != 3 && response != 4 && response != 5)
            {
                Console.Write("Please choose a valid input: ");
                response = int.Parse(Console.ReadLine());
            }

            if (response == 1)
            {

                Entry newEntry = new Entry();
                newEntry.NewEntry();

                j1.AddEntry(newEntry);
                // Don't need to pass in a variable, can pass in the class 
                // instead since writeEntry updates the variables.
            }

            else if (response == 2)
            {
                j1.DisplayJournal();
            }

            else if (response == 3)
            {
                Console.WriteLine("Where would you like to save this to? (type filename, end with .txt):");
                j1._filename = Console.ReadLine();
                j1.SaveJournal(j1._filename);
            }

            else if (response == 4)
            {
                j1.ReadFiles(j1._filename);
            }

            if (response == 5)
            {
                Console.WriteLine("Have a good day!");
            }
        }while (response >= 1 && response <= 4);


        return response;
    }
}