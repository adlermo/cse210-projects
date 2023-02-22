public class ReflectionService
{
    private List<Prompt> _promptList = new List<Prompt>();
    private List<Question> _questionList = new List<Question>();
    private List<Prompt> _promptHistory = new List<Prompt>();
    private List<Question> _questionHistory = new List<Question>();

    public ReflectionService()
    {
        // Initializing prompts List
        this._promptList.Add(new Prompt("Think of a time when you stood up for someone else."));
        this._promptList.Add(new Prompt("Think of a time when you did something really difficult."));
        this._promptList.Add(new Prompt("Think of a time when you helped someone in need."));
        this._promptList.Add(new Prompt("Think of a time when you did something truly selfless."));

        // Initializing question List
        this._questionList.Add(new Question("Why was this experience meaningful to you?"));
        this._questionList.Add(new Question("Have you ever done anything like this before?"));
        this._questionList.Add(new Question("How did you get started?"));
        this._questionList.Add(new Question("How did you feel when it was complete?"));
        this._questionList.Add(new Question("What made this time different than other times when you were not as successful ?"));
        this._questionList.Add(new Question("What is your favorite thing about this experience?"));
        this._questionList.Add(new Question("What could you learn from this experience that applies to other situations?"));
        this._questionList.Add(new Question("What did you learn about yourself through this experience?"));
        this._questionList.Add(new Question("How can you keep this experience in mind in the future?"));
    }

    public string GetRandomPrompt()
    {
        Prompt p = handleDuplicatedPrompt(); // Does the magic

        return p.GetPrompt(); // Returns the prompt as string
    }

    public string GetRandomQuestion()
    {
        Question q = handleDuplicatedQuestion(); // Does the magic

        return q.GetQuestion(); // Returns the prompt as string
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

    private Question handleDuplicatedQuestion()
    {
        // When the user has used all Questions we restart the list
        if (this._questionList.Count() == 0)
        {
            Console.WriteLine("We've ran out of questions. You'll receive repeated questions from now!");
            RecycleQuestionHistory();
        }

        // Gets a random question from my list size
        int index = new Random().Next(0, this._questionList.Count() - 1);
        Question prompt = this._questionList[index];

        // Removes from main list so it won't repeat until finished
        this._questionList.Remove(prompt);
        // Adds questions to history so we can get that later
        this._questionHistory.Add(prompt);

        return prompt;
    }

    private void RecyclePromptHistory()
    {
        // Retrieves everything back from the history
        this._promptList.AddRange(this._promptHistory);
        // Clears the history list
        this._promptHistory.Clear();
    }

    private void RecycleQuestionHistory()
    {
        // Retrieves everything back from the history
        this._questionList.AddRange(this._questionHistory);
        // Clears the history list
        this._questionHistory.Clear();
    }
}