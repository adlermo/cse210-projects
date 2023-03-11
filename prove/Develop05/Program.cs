class Program
{
    static GoalService service = new GoalService();

    // EXCEEDING REQUIREMENTS: I created an autosave and autoload feature
    static void Main(string[] args)
    {
        int opt = 0;

        if (File.Exists("autosave.json"))
        {
            Console.WriteLine("We identified you have a autosave from last session.");
            Console.WriteLine("Do you wish to continue last session data 'autosave.json'? (y/N)");
            string confirm = Console.ReadLine().ToLower();
            if (confirm != "" && !confirm.StartsWith("n".ToLower())) service.LoadFile("autosave");
        }

        while (opt != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {service.GetScore()} points.");
            Console.WriteLine();

            opt = MenuOption();

            Action(opt);
        }
    }

    static int MenuOption()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List My Goals");
        Console.WriteLine("  3. Save My Goals (to file)");
        Console.WriteLine("  4. Load My Goals (from file)");
        Console.WriteLine("  5. Record Event (goal completion)");
        Console.WriteLine("  6. Quit");

        Console.Write("Please, enter a valid option number: ");
        return int.TryParse(Console.ReadLine(), out int i) ? i : 0;
    }

    static void Action(int option)
    {
        switch (option)
        {
            case 1:
                service.CreateGoal();
                break;

            case 2:
                service.PrintGoals();
                break;

            case 3:
                service.SaveFile(null);
                break;

            case 4:
                service.LoadFile(null);
                break;

            case 5:
                service.CompleteGoal();
                break;

            case 6:
                Console.WriteLine();
                Console.WriteLine("Quitting Program...");

                // Only autosaving progress if there's a score
                if (service.GetScore() > 0)
                {
                    Console.WriteLine("Auto saving progress as 'autosave.json'...");
                    service.SaveFile("autosave");
                }
                break;

            default:
                Console.WriteLine("Please, enter a valid option or quit the program");
                break;
        }
    }
}
