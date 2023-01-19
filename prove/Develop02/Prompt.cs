public class Prompt
{
    string _prompt;
    public Prompt(string text)
    {
        this._prompt = text;
    }

    public string GetPrompt()
    {
        return _prompt;
    }
}