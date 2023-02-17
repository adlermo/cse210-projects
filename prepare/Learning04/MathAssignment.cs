class MathAssignment : Assignment
{

    private string _textBookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        this._textBookSection = section;
        this._problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {this._textBookSection} Problems {this._problems}";
    }
}