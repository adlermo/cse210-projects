class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    protected bool _completed;
    protected int? _bonusQualification;
    protected int? _timesCompleted;
    protected int? _bonusPoints;

    // Class Properties for JSON Serializer / Deserializer
    public string type { get; set; }
    public string name { get { return _name; } set { _name = value; } }
    public string description { get { return _description; } set { _description = value; } }
    public int points { get { return _points; } set { _points = value; } }
    public bool completed { get { return _completed; } set { _completed = value; } }
    public int? bonusPoints { get { return _bonusPoints; } set { _bonusPoints = value; } }
    public int? bonusQualification { get { return _bonusQualification; } set { _bonusQualification = value; } }
    public int? timesCompleted { get { return _timesCompleted; } set { _timesCompleted = value; } }


    public Goal() { type = this.GetType().ToString(); }
    public Goal(bool initialize)
    {
        type = this.GetType().ToString();

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
