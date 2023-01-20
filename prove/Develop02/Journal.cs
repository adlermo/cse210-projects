public class Journal
{

    List<Entry> _entryList = new List<Entry>();

    public Journal() { }
    public Journal(File file)
    {
        this._entryList = file.GetEntries();
    }

    public void WriteEntry(Entry entry)
    {
        this._entryList.Add(entry);
    }

    public void DisplayEntries()
    {
        _entryList.ForEach(entry =>
        {
            entry.Display();
        });
    }
}