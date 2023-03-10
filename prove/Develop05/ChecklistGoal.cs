class ChecklistGoal : Goal
{
    private int _bonusQualification;
    private int _completionCounter;
    private int _bonusPoints;

    public ChecklistGoal() : base() { }

    public override int CompleteGoal()
    {
        if (_bonusQualification == _completionCounter)
        {
            _completed = true;
            return _points + _bonusPoints;
        }

        return _points;
    }
}