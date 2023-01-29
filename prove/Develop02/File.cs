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
                // Writes a string formatted Entry from the list to a line in the file
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
            // Breaks my line into 3 pieces at least by using the separator ; (semicolon)
            string[] attr = line.Split(';');

            // It initializes a list of Entry with data loaded from line
            loadedEntries.Add(new Entry(attr[2], attr[1], attr[0]));
        }

        return loadedEntries;
    }
}