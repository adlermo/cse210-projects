using Pastel;
// EXCEEDING REQUIREMENTS: adding colors to console outputs

public class PromptHandler
{
    List<Prompt> _promptList = new List<Prompt>();
    List<Prompt> _promptHistory = new List<Prompt>();

    // Constructor initializes all my prompts in the list
    public PromptHandler()
    {
        this._promptList.Add(new Prompt("Who was the most interesting person I interacted with today?"));
        this._promptList.Add(new Prompt("What was the best part of my day?"));
        this._promptList.Add(new Prompt("How did I see the hand of the Lord in my life today?"));
        this._promptList.Add(new Prompt("What was the strongest emotion I felt today?"));
        this._promptList.Add(new Prompt("If I had one thing I could do over today, what would it be?"));
        this._promptList.Add(new Prompt("Write an advice to your older self in 5 years:"));
        this._promptList.Add(new Prompt("How many cups of water did you drink today?"));
        this._promptList.Add(new Prompt("Who did you help today? By doing what?"));
    }

    public string GetRandomPrompt()
    {
        Prompt p = handleDuplicated(); // Does the magic

        return p.GetPrompt(); // Returns the prompt as string
    }

    Prompt handleDuplicated()
    {
        // When the user has used all Prompts we restart the list
        if (this._promptList.Count() == 0)
        {
            Console.WriteLine("We've ran out of prompts. You'll receive repeated prompts from now!".Pastel(ColorScheme.YELLOW));
            RecycleHistory();
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

    void RecycleHistory()
    {
        // Retrieves everything back from the history
        this._promptList.AddRange(this._promptHistory);
        // Clears the history list
        this._promptHistory.Clear();
    }
}