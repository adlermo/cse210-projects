class ChecklistGoal : Goal
{
    public ChecklistGoal() : base() { this._timesCompleted = 0; }
    public ChecklistGoal(bool initialize) : base(initialize)
    {
        this._timesCompleted = 0;

        Console.Write("Enter how many times to complete for a bonus: ");
        this._bonusQualification = int.Parse(Console.ReadLine());

        Console.Write("The amount of bonus points you'll get: ");
        this._bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int CompleteGoal()
    {
        ++this._timesCompleted;

        if (this._bonusQualification == this._timesCompleted)
        {
            this._completed = true;
            return this._points + (int)this._bonusPoints;
        }

        return this._points;
    }

    public override string DisplayFormatted()
    {
        string mark = this._completed ? "X" : " ";

        return $"[{mark}] {this.GetName()} — {this.GetDescription()} | {this._timesCompleted}/{this._bonusQualification} completed";
    }
}