public class PromptHandler
{
    List<Prompt> _promptList = new List<Prompt>();
    List<Prompt> _promptHistory = new List<Prompt>();

    public PromptHandler()
    {
        this._promptList.Add(new Prompt("Who was the most interesting person I interacted with today?"));
        this._promptList.Add(new Prompt("What was the best part of my day?"));
        this._promptList.Add(new Prompt("How did I see the hand of the Lord in my life today?"));
        this._promptList.Add(new Prompt("What was the strongest emotion I felt today?"));
        this._promptList.Add(new Prompt("If I had one thing I could do over today, what would it be?"));
        this._promptList.Add(new Prompt("Write an advice to your older self in 5 years:"));

        this._promptList.Add(new Prompt("How many cups of water did you drink today?"));
    }

    public string GetRandomPrompt()
    {
        Prompt p = handleDuplicated();

        return p.GetPrompt();
    }

    Prompt handleDuplicated()
    {
        // When the user has used all Prompts we restart the list
        if (this._promptList.Count().Equals(0)) { RecycleHistory(); }

        int index = new Random().Next(1, this._promptList.Count());
        Prompt prompt = this._promptList[index];

        this._promptList.Remove(prompt);
        this._promptHistory.Add(prompt);

        return prompt;
    }

    void RecycleHistory()
    {
        this._promptList = this._promptHistory;

        this._promptHistory.Clear();
    }

}