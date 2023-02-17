class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment(string name, string topic)
    {
        this._studentName = name;
        this._topic = topic;
    }

    public string GetSummary()
    {
        return $"{this._studentName} - {this._topic}";
    }

    protected string GetName()
    {
        return this._studentName;
    }
}