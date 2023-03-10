class EternalGoal : Goal
{
    public EternalGoal() : base() { }

    public override int CompleteGoal()
    {
        return _points;
    }
}