

public class File
{
    public List<Entry> _entries = new List<Entry>();

    public File(string fileName)
    {
        // TODO: Read File and add each line to _entries as Entry
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }
}