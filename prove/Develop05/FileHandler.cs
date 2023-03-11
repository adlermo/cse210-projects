using System.Text.Json;

class FileHandler
{
    public FileHandler() { }

    public T Read<T>(string file)
    {
        string text = File.ReadAllText($"{file.Split(".")[0]}.json");
        return JsonSerializer.Deserialize<T>(text);
    }

    public void Write<T>(string file, T quest)
    {
        string text = JsonSerializer.Serialize<T>(quest);
        File.WriteAllText($"{file.Split(".")[0]}.json", text);
    }
}
