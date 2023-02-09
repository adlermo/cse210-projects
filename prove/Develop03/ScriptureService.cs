class ScriptureService
{
    private List<Scripture> _library;

    public ScriptureService()
    {
        JsonFileReader reader = new JsonFileReader();
        this._library = reader.Read<List<Scripture>>();
    }

    public void DisplayLibrary()
    {
        this._library.ForEach(reference =>
        {
            Console.Write($"{this._library.IndexOf(reference) + 1} — ");
            reference.Display();
        });
    }

    public Scripture ChooseRandom()
    {
        int r = new Random().Next(0, this._library.Count() - 1);
        return this._library[r];
    }
    public Scripture ChooseOne(int r)
    {
        return this._library[r];
    }
}
