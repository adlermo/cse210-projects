public class File
{
    public File() { }

    public void SaveToFile(string filename, List<Entry> entries)
    {
        // EXCEEDING REQUIREMENTS: filename handling to save .csv only
        using (StreamWriter writer = new StreamWriter($"{filename.Split('.')[0]}.csv"))
        {
            entries.ForEach(entry =>
            {
                writer.WriteLine(entry.GetEntry());
            });
        }
    }

    public List<Entry> LoadFromFile(string filename)
    {
        // EXCEEDING REQUIREMENTS: filename handling to load .csv only
        string[] lines = System.IO.File.ReadAllLines($"{filename.Split('.')[0]}.csv");
        List<Entry> loadedEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] attr = line.Split(';');

            loadedEntries.Add(new Entry(attr[2], attr[1], attr[0]));
        }

        return loadedEntries;
    }
}