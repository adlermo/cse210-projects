using Pastel;
// EXCEEDING REQUIREMENTS: Adding color to console outputs

class Program
{
    static PromptHandler promptHandler = new PromptHandler();
    static Journal journal = new Journal();
    static bool session = true;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal Program!".PastelBg(ColorScheme.KOMBU).Pastel(ColorScheme.YELLOW));

        while (session)
        {
            string userInput = ShowMenuAndReturnInput();

            switch (userInput)
            {
                case "1":
                    // Receive a New Entry
                    string prompt = promptHandler.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string userLine = Console.ReadLine();
                    journal.SaveEntry(new Entry(userLine, prompt));

                    Console.WriteLine("Entry saved!".Pastel(ColorScheme.GREEN));
                    break;

                case "2":
                    // Display Entries
                    journal.DisplayEntries();
                    break;

                case "3":
                    // Load Journal from a File
                    LoadJournal();
                    // EXCEEDING REQUIREMENTS: loading file from .csv
                    break;

                case "4":
                    // Save Journal in a File
                    Console.WriteLine("Enter filename to save:" + " (.ext will be ignored /\\.*/)".Pastel(ColorScheme.KOMBU));
                    // EXCEEDING REQUIREMENTS: saving file to .csv
                    journal.WriteJournalToFile(Console.ReadLine());
                    break;

                case "5":
                    // Quits the session
                    Console.WriteLine("Finishing Your Session. Goodbye!".Pastel(ColorScheme.KOMBU));
                    session = false;
                    break;

                default:
                    Console.WriteLine($"{userInput} is an invalid option. Please, try 1 - 5.".Pastel(ColorScheme.RED));
                    break;
            }
        }
    }


    static string ShowMenuAndReturnInput()
    {
        Console.WriteLine("——————————————————————————————————————————————————————————————————————".Pastel(ColorScheme.KOMBU));
        Console.WriteLine("Please enter the number for one of the menu choices: ");
        Console.WriteLine("1. Write new Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Load my Journal");
        Console.WriteLine("4. Save my Journal");
        Console.WriteLine("5. Quit my Session\n");
        Console.WriteLine("What do you want to do? ");

        return Console.ReadLine();
    }

    static void LoadJournal()
    {
        try
        {
            Console.WriteLine("Enter filename to load:" + " (.ext will be ignored /\\.*/)".Pastel(ColorScheme.KOMBU));
            journal.LoadJournalFromFile(Console.ReadLine());
            Console.WriteLine("File loaded!".Pastel(ColorScheme.GREEN));
        }
        catch (System.Exception)
        {
            Console.WriteLine("Couldn't load file! Please check the file.".Pastel(ColorScheme.RED));
        }
    }
}
