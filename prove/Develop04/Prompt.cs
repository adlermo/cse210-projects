public class Prompt
{
    private string _prompt;

    // Constructor
    public Prompt(string text)
    {
        this._prompt = text;
    }

    public string GetPrompt()
    {
        return _prompt;
    }
}