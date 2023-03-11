class EternalGoal : Goal
{
    public EternalGoal() : base() { }
    public EternalGoal(bool initialize) : base(initialize) { }

    public override int CompleteGoal()
    {
        return _points;
    }
}