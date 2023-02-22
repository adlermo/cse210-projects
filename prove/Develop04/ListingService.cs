public class ListingService
{
    private List<Prompt> _promptList = new List<Prompt>();
    private List<Prompt> _promptHistory = new List<Prompt>();
    private List<string> _answersByPrompt = new List<string>();

    public ListingService()
    {
        // Initializing prompts List
        this._promptList.Add(new Prompt("Who are people that you appreciate?"));
        this._promptList.Add(new Prompt("What are personal strengths of yours?"));
        this._promptList.Add(new Prompt("Who are people that you have helped this week?"));
        this._promptList.Add(new Prompt("When have you felt the Holy Ghost this month?"));
        this._promptList.Add(new Prompt("Who are some of your personal heroes?"));
    }

    public string GetRandomPrompt()
    {
        Prompt p = handleDuplicatedPrompt(); // Does the magic

        return p.GetPrompt(); // Returns the prompt as string
    }

    public void SaveAnswerToPrompt(string q)
    {
        this._answersByPrompt.Add(q);
    }

    public int AnswersByPromptSize()
    {
        return this._answersByPrompt.Count();
    }

    private Prompt handleDuplicatedPrompt()
    {
        // When the user has used all Prompts we restart the list
        if (this._promptList.Count() == 0)
        {
            Console.WriteLine("We've ran out of prompts. You'll receive repeated prompts from now!");
            RecyclePromptHistory();
        }

        // Gets a random prompt from my list size
        int index = new Random().Next(0, this._promptList.Count() - 1);
        Prompt prompt = this._promptList[index];

        // Removes from main list so it won't repeat until finished
        this._promptList.Remove(prompt);
        // Adds prompts to history so we can get that later
        this._promptHistory.Add(prompt);

        return prompt;
    }

    private void RecyclePromptHistory()
    {
        // Retrieves everything back from the history
        this._promptList.AddRange(this._promptHistory);
        // Clears the history list
        this._promptHistory.Clear();
    }
}
