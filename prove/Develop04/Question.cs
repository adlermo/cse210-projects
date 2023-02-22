public class Question
{
    private string _prompt;

    // Constructor
    public Question(string text)
    {
        this._prompt = text;
    }

    public string GetQuestion()
    {
        return _prompt;
    }
}