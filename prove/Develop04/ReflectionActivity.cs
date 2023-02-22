class ReflectionActivity : Activity
{
    public ReflectionActivity(string name, string description) : base(name, description) { }

    public void ReflectionExercise()
    {
        ReflectionService service = new ReflectionService();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"  --- {service.GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Related to the experience, ponder on each of the following questions:");
        Console.Write("Starting in ");
        DisplaySeconds(3);
        Console.Clear();

        // Resetting Activity Duration
        SetDuration(GetDuration());
        while (!IsActivityTimedUp())
        {
            Console.WriteLine($"> {service.GetRandomQuestion()}");
            DisplaySpinner(10);
        }
    }
}
