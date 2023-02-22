class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base(name, description) { }

    public void ListingExercise()
    {
        ListingService service = new ListingService();
        string prompt = service.GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many thoughts you'll have to the following prompt:\n");
        Console.WriteLine($"  --- {prompt} ---\n");

        Console.Write("Starting in ");
        DisplaySeconds(4);
        Console.WriteLine();

        // Resetting Activity Duration
        SetDuration(GetDuration());
        while (!IsActivityTimedUp())
        {
            Console.Write("> ");
            service.SaveAnswerToPrompt(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {service.AnswersByPromptSize()} items");
    }
}
