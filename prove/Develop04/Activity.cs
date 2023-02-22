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

    private void SetDuration(int duration)
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

        StartActivity();
    }

    public void DisplayClosingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!\n");
        DisplaySpinner(4);

        Console.WriteLine();
        Console.WriteLine($"You have completed {this._duration} seconds of the {this._name} Activity\n");
        DisplaySpinner(4);
        Console.Clear();
    }

    private void StartActivity()
    {
        Console.Write("Please, enter the activity duration in seconds (default is 60s): ");
        int durationInput = int.TryParse(Console.ReadLine(), out int i) ? i : 60;

        Console.Clear();
        Console.Write("Get ready! ");
        DisplaySeconds(3);
        Console.WriteLine();

        // As SetDuration starts the activity counter we're doing it the last
        SetDuration(durationInput);
    }

    protected bool IsActivityTimedUp()
    {
        this._elapsedTime = DateTime.Now;

        // Returns whether desired duration was reached
        return this._expectedEndingTime < this._elapsedTime;
    }

    protected void DisplaySeconds(int s)
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

    protected void DisplaySpinner(int s)
    {
        while (s > 0)
        {
            Thread.Sleep(200);

            Console.Write("*");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("**");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\b \b");

            Console.Write("***");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");

            Console.Write("****");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");
            Console.Write("\b \b");

            s--;
        }
    }
}