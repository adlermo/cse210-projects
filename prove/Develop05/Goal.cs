class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    protected bool _completed;

    public Goal()
    {
        Console.Write("Enter the name for your goal: ");
        this._name = Console.ReadLine();

        Console.Write("Give it a short description: ");
        this._description = Console.ReadLine();

        Console.Write("Assign your goal a value as points: ");
        this._points = int.Parse(Console.ReadLine());

        this._completed = false;
    }

    public void SetName(string name) { this._name = name; }
    public string GetName() { return this._name; }

    public void SetDescription(string description) { this._description = description; }
    public string GetDescription() { return this._description; }

    public void SetPoints(int points) { this._points = points; }
    public int GetPoints() { return this._points; }

    public bool GetCompleted() { return this._completed; }


    public virtual int CompleteGoal()
    {
        this._completed = true;
        return this._points;
    }

    public virtual string DisplayFormatted()
    {
        string mark = this._completed ? "X" : " ";
        return $"[{mark}] {this._name} — {this._description}";
    }
}
