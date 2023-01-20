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
                    journal.WriteEntry(new Entry(userLine, prompt));

                    Console.WriteLine("Entry saved!".Pastel(ColorScheme.GREEN));
                    break;

                case "2":
                    // Display Entries
                    journal.DisplayEntries();
                    break;

                case "3":
                    // Load Journal from a File
                    break;

                case "4":
                    // Save Journal in a File
                    break;

                case "5":
                    session = false;
                    Console.WriteLine("Quitting Journal Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("This is more likely an invalid option. Please, try 1 - 5.");
                    break;
            }
        }
    }


    static string ShowMenuAndReturnInput()
    {
        Console.WriteLine("——————————————————————————————————————————————————————————————————————");
        Console.WriteLine("\nPlease enter the number for one of the menu choices: ");
        Console.WriteLine("1. Write new Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Load my Journal");
        Console.WriteLine("4. Save my Journal");
        Console.WriteLine("5. Quit my Session\n");
        Console.WriteLine("What do you want to do? ");

        return Console.ReadLine();
    }
}
