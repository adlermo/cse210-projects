class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    private DateTime _startTime;
    private DateTime _elapsedTime;
    private DateTime _expectedEndingTime;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
        this._startTime = DateTime.Now;
    }

    public void SetDuration(int duration)
    {
        this._duration = duration;
        this._elapsedTime = DateTime.Now;
        this._expectedEndingTime = this._startTime.AddSeconds(duration);
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {this._name} Activity\n");
        Console.WriteLine($"{this._description}\n");
        Console.WriteLine("\nGet ready!\n");
        DisplaySeconds(3);
    }

    public void DisplayClosingMessage()
    {
        Console.WriteLine("Well Done!\n");
        Console.WriteLine($"You have completed {this._duration} seconds of the {this._name} Activity\n");
        DisplaySeconds(5);

        Console.Clear();
    }

    protected bool IsActivityTimedUp()
    {
        this._elapsedTime = DateTime.Now;

        // Returns whether desired duration was reached
        return this._expectedEndingTime < this._elapsedTime;
    }

    public void DisplaySeconds(int s)
    {
        while (s > 0)
        {
            // ↶ ↺ ⟲ ⤹ ⤺ ⤻ ⤿ ⥀
            Console.Write($"{s}");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            s--;
        }
    }
}