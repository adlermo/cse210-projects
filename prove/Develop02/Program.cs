using Pastel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal Program!");

        bool session = true;
        PromptHandler promptHandler = new PromptHandler();
        Journal journal = new Journal();

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
                    try
                    {
                        Console.WriteLine("Enter filename to load:" + "(.ext will be ignored /\\.*/)".Pastel(ColorScheme.KOMBU));
                        journal.LoadJournalFromFile(Console.ReadLine());
                        // Console.WriteLine("File loaded!".Pastel(ColorScheme.GREEN));
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Couldn't load file! Please check the file.".Pastel(ColorScheme.RED));
                    }
                    break;

                case "4":
                    // Save Journal in a File
                    Console.WriteLine("Enter filename to save:" + "(.ext will be ignored /\\.*/)".Pastel(ColorScheme.KOMBU));
                    journal.WriteJournalToFile(Console.ReadLine());
                    break;

                case "5":
                    session = false;
                    Console.WriteLine("Quitting Journal Program. Goodbye!".Pastel(ColorScheme.KOMBU));
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
}
