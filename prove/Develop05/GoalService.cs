class GoalService
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalService() { this._score = 0; }

    public void CreateGoal()
    {
        Console.WriteLine("Which kind of goal would you like to create?");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Please, enter a valid option number: ");
        int choice = int.TryParse(Console.ReadLine(), out int i) ? i : 0;

        switch (choice)
        {
            case 1:
                CreateSimpleGoal();
                break;

            case 2:
                CreateEternalGoal();
                break;

            case 3:
                CreateChecklistGoal();
                break;

            default:
                Console.Write("Invalid option!");
                break;
        }
    }

    public void PrintGoals()
    {
        Console.WriteLine("These are the goals:");
        Console.WriteLine();
        foreach (var g in this._goals.Select((goal, index) => (goal, index)))
        {
            Console.WriteLine($"{g.index + 1}. {g.goal.DisplayFormatted()}");
        }
        Console.WriteLine();
    }

    public void CompleteGoal()
    {
        Console.WriteLine("Check the list of goals:");
        Console.WriteLine();
        foreach (var g in this._goals.Select((goal, index) => (goal, index)))
        {
            Console.WriteLine($"{g.index + 1}. {g.goal.GetName()}");
        }
        Console.Write("Choose the goal you've done: ");

        int goalIndex = int.TryParse(Console.ReadLine(), out int i) ? i - 1 : -1;
        if (goalIndex == -1) Console.WriteLine("Invalid option!");
        else this._score += this._goals[goalIndex].CompleteGoal();
    }

    // Method to create a Simple Goal
    private void CreateSimpleGoal()
    {
        this._goals.Add(new Goal());
    }

    // Method to create a Eternal Goal
    private void CreateEternalGoal()
    {
        this._goals.Add(new EternalGoal());
    }

    // Method to create a Checklist Goal
    private void CreateChecklistGoal()
    {
        this._goals.Add(new ChecklistGoal());
    }

}
