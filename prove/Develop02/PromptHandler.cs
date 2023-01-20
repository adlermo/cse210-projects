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
    }

    public string GetRandomPrompt()
    {
        int index = new Random().Next(1, 5);
        Prompt p = this._promptList[index];
        this._promptHistory.Add(p);

        return p.GetPrompt();
    }

}