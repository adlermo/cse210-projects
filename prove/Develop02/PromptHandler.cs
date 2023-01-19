public class PromptHandler
{
    List<Prompt> _promptList = new List<Prompt>();
    Prompt _promptHistory;

    public PromptHandler()
    {
        this._promptList.Append(new Prompt("Who was the most interesting person I interacted with today?"));
        this._promptList.Append(new Prompt("What was the best part of my day?"));
        this._promptList.Append(new Prompt("How did I see the hand of the Lord in my life today?"));
        this._promptList.Append(new Prompt("What was the strongest emotion I felt today?"));
        this._promptList.Append(new Prompt("If I had one thing I could do over today, what would it be?"));
    }

    string GetRandomPrompt()
    {
        int index = new Random().Next(0, 4);
        return this._promptList[index].GetPrompt();
    }

}