class Scripture
{
    private string _book;
    private int _chapter;
    private List<int> _verse;
    private List<string> _text;

    // JSON Deserializer Properties | Getters and Setters
    public string book { get { return _book; } set { _book = value; } }
    public int chapter { get { return _chapter; } set { _chapter = value; } }
    public List<int> verse { get { return _verse; } set { _verse = value; } }
    public List<string> text { get { return _text; } set { _text = value; } }

    public void Display()
    {
        int size = this._verse.Count();
        if (size == 1)
            Console.WriteLine($"{this._book} {this._chapter}:{this._verse[0]}");
        else
        {
            Console.WriteLine($"{this._book} {this._chapter}:{String.Join(",", this._verse)}");
        }
    }

    public void DisplayWithVerse()
    {
        int size = this._verse.Count();
        if (size == 1)
        {
            Console.WriteLine($"{this._book} {this._chapter}:{this._verse[0]}");
            Console.WriteLine($"{this._text[0]}");
        }
        else
        {
            Console.WriteLine($"{this._book} {this._chapter}:{String.Join(",", this._verse)}");
            Console.WriteLine($"{String.Join("\n", this._text)}");
        }
    }
}
