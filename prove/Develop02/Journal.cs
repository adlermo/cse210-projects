public class Journal
{
    List<Entry> _entryList = new List<Entry>();

    public Journal() { }

    public void SaveEntry(Entry entry)
    {
        this._entryList.Add(entry);
    }

    public void DisplayEntries()
    {
        this._entryList.ForEach(entry =>
        {
            entry.Display();
        });
    }

    public void WriteJournalToFile(string filename)
    {
        File file = new File();
        file.SaveToFile(filename, this._entryList);
    }

    public void LoadJournalFromFile(string filename)
    {
        File file = new File();
        this._entryList = file.LoadFromFile(filename);
    }
}