class GoalService
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;

    public GoalService() { this._score = 0; this._level = 0; }

    public int GetScore() { return this._score; }

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
        else
        {
            this._score += this._goals[goalIndex].CompleteGoal();
            Console.WriteLine($"Congratulations! You now have {this._score} points.");
            Console.WriteLine();
        }
    }

    public void SaveFile(string file)
    {
        if (file == null)
        {
            Console.WriteLine();
            Console.Write("Please, enter the a name to save the file: ");
            file = Console.ReadLine();
        }

        try
        {
            Quest quest = new Quest();
            quest.score = this._score;
            quest.level = this._level;
            quest.goals = this._goals;

            new FileHandler().Write(file, quest);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Couldn't save file: {e.Message}");
        }
    }

    public void LoadFile(string file)
    {
        if (file == null)
        {
            Console.WriteLine();
            Console.Write("Please, enter the file name to load: ");
            file = Console.ReadLine();
        }

        try
        {
            Quest quest = new FileHandler().Read<Quest>(file);
            this._score = quest.score;
            this._level = quest.level;
            this._goals.Clear();

            foreach (var goal in quest.goals)
            {
                switch (goal.type)
                {
                    case "EternalGoal":
                        EternalGoal e = new EternalGoal();
                        e.name = goal.name;
                        e.description = goal.description;
                        e.points = goal.points;
                        this._goals.Add(e);
                        break;

                    case "ChecklistGoal":
                        ChecklistGoal c = new ChecklistGoal();
                        c.name = goal.name;
                        c.description = goal.description;
                        c.points = goal.points;
                        c.bonusPoints = goal.bonusPoints;
                        c.bonusQualification = goal.bonusQualification;
                        c.timesCompleted = goal.timesCompleted;
                        this._goals.Add(c);
                        break;

                    default:
                        this._goals.Add(goal);
                        break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Couldn't load file: {e.Message}");
        }
    }

    // Method to create a Simple Goal
    private void CreateSimpleGoal()
    {
        this._goals.Add(new Goal(true));
    }

    // Method to create a Eternal Goal
    private void CreateEternalGoal()
    {
        this._goals.Add(new EternalGoal(true));
    }

    // Method to create a Checklist Goal
    private void CreateChecklistGoal()
    {
        this._goals.Add(new ChecklistGoal(true));
    }

}

class Quest
{
    public int score { get; set; }
    public int level { get; set; }
    public List<Goal> goals { get; set; }
}