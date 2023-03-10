class Goal
{
    private string _name;
    private string _description;
    protected int _points;
    protected bool _completed;

    public Goal() { this._completed = false; }

    public virtual int CompleteGoal()
    {
        this._completed = true;
        return this._points;
    }
}
