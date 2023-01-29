public class Journal
{
    List<Entry> _entryList = new List<Entry>();

    // Constructor
    public Journal() { }

    // It adds an Entry object to my list
    public void SaveEntry(Entry entry)
    {
        this._entryList.Add(entry);
    }

    // Display my list of entries formatted
    public void DisplayEntries()
    {
        this._entryList.ForEach(entry =>
        {
            entry.Display();
        });
    }

    // Saves to a csv file
    public void WriteJournalToFile(string filename)
    {
        File file = new File();
        file.SaveToFile(filename, this._entryList);
    }

    // Loads from a csv file
    public void LoadJournalFromFile(string filename)
    {
        File file = new File();
        this._entryList = file.LoadFromFile(filename);
    }
}