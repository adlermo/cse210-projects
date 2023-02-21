class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    public void SetDuration(int duration)
    {
        this._duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {this._name} Activity\n");
        Console.WriteLine($"{this._description}\n");
    }

    public void DisplayClosingMessage()
    {
        Console.WriteLine("Well Done!\n");
        Console.WriteLine($"You have completed {this._duration} seconds of the {this._name} Activity\n");
    }
}