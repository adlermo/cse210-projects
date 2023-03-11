class Program
{
    static GoalService service = new GoalService();

    static void Main(string[] args)
    {
        int opt = 0;

        while (opt != 6)
        {
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

                break;

            case 4:

                break;

            case 5:
                service.CompleteGoal();
                break;

            case 6:
                Console.WriteLine();
                Console.WriteLine("Quitting Program...");
                break;

            default:
                Console.WriteLine("Please, enter a valid option or quit the program");
                break;
        }
    }
}
